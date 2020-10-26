using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MiddleExam
{
    public partial class MainForm : Form
    {
        private enum Direction
        {
            Left, Right
        }

        /// <summary>
        /// <see cref="_lineColor"/>를 사용하여 새로운 SolidBrush 인스턴스를 반환합니다.
        /// </summary>
        private Brush LineBrush
        {
            get => new SolidBrush(_lineColor);
        }

        /// <summary>
        /// LineSize의 프로퍼티를 수정할 때 값이 1 미만, 10 초과가 되지 않도록 변경하여 적용합니다.
        /// </summary>
        private int LineSize
        {
            get => _lineSize;
            set => _lineSize = value < 1 ? 1 : value > 10 ? 10 : value;
        }

        private readonly Queue<Point> _clickPoints = new Queue<Point>();

        private Bitmap _bitmap;

        private int _lineSize = 5;

        private Color _lineColor = Color.Black;

        private int _clickCount = 0;

        private const float ImageSize = 100;
        private const float Speed = 5f;
        private PointF _imagePosition = new PointF(0f, 100f);
        private Direction _imageMoveDirection = Direction.Right;

        public MainForm()
        {
            InitializeComponent();
            _bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
            UpdateBitmap();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            if (_bitmap != null)
            {
                e.Graphics.DrawImage(_bitmap, 0, 0);
            }
        }

        /// <summary>
        /// 창 크기가 조절 될 때 비트맵 크기로 자동으로 조절하기 위해 사용합니다.
        /// </summary>
        private void UpdateBitmap()
        {
            _bitmap.Dispose();
            _bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
            UpdateWindow();
        }

        /// <summary>
        /// 더블버퍼링으로 비트맵을 새로 그리고 적용하기 위해 사용합니다.
        /// </summary>
        private void UpdateWindow()
        {
            // using을 쓰면 graphics가 자동으로 제거되기 때문에 가비지 생성 안함
            using (Graphics graphics = Graphics.FromImage(_bitmap))
            {
                graphics.Clear(SystemColors.Window);

                #region Draw Icon
                graphics.DrawImage(StaticResources.Icon, new RectangleF(_imagePosition, new SizeF(ImageSize, ImageSize)));
                #endregion

                #region Draw Line
                var pts = _clickPoints.ToArray();
                Pen pen = new Pen(LineBrush, LineSize);
                if (pts.Length == 1)
                {
                    graphics.FillEllipse(LineBrush, new Rectangle(pts[0], new Size(LineSize, LineSize)));
                }
                else if (pts.Length == 2)
                {
                    pen.StartCap = LineCap.RoundAnchor;
                    pen.EndCap = LineCap.ArrowAnchor;

                    graphics.DrawLine(pen, pts[0], pts[1]);
                }
                #endregion

                #region Draw Info text
                Point uiPosition = new Point(10, 10);
                graphics.DrawString($"총 클릭 수: {_clickCount}", Font, Brushes.Black, uiPosition);

                uiPosition.Y += 15;
                graphics.DrawString($"색 변경 [C]: {_lineColor}", Font, Brushes.Black, uiPosition);

                uiPosition.Y += 15;
                graphics.DrawString($"굵기 변경 [UP/DOWN]: {_lineSize}", Font, Brushes.Black, uiPosition);
                #endregion
            }
            Invalidate();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            UpdateBitmap();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            // try-finally를 사용하여 try 내에서 return을 사용했을 때 
            // 무조건 UpdateWindow()가 실행되도록 하였습니다.
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    _clickPoints.Enqueue(e.Location);
                    if (_clickPoints.Count == 3)
                    {
                        _clickPoints.Dequeue();
                    }
                    _clickCount++;
                    return;
                }
            }
            finally
            {
                UpdateWindow();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.C)
                {
                    Random randomize = new Random();
                    _lineColor = Color.FromArgb(randomize.Next(0, 256), randomize.Next(0, 256), randomize.Next(0, 256));
                    return;
                }

                if (e.KeyCode == Keys.Up)
                {
                    LineSize++; // LineSize 프로퍼티에서 알아서 조정하므로 여기서는 수정할 필요 X
                    return;
                }

                if (e.KeyCode == Keys.Down)
                {
                    LineSize--;
                    return;
                }
            }
            finally
            {
                UpdateWindow();
            }
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            // 이미지의 Y 위치가 항상 창의 가운데로 오도록 했습니다.
            // 가운데 위치 구하는 공식: 2/[창높이] - 2/[이미지높이]
            // 왜냐하면 이미지가 그려지는 위치는 이미지의 (0, 0) 지점이기 때문에!
            _imagePosition.Y = ClientSize.Height / 2 - ImageSize / 2;

            switch (_imageMoveDirection)
            {
                case Direction.Left:
                    _imagePosition.X -= Speed;
                    if (_imagePosition.X <= ClientRectangle.Left)
                    {
                        _imageMoveDirection = Direction.Right;
                    }
                    break;
                case Direction.Right:
                    _imagePosition.X += Speed;
                    if (_imagePosition.X + ImageSize >= ClientRectangle.Right)
                    {
                        _imageMoveDirection = Direction.Left;
                    }
                    break;
            }
            UpdateWindow();
        }
    }
}
