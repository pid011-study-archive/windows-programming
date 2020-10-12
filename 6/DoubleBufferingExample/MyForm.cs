using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoubleBufferingExample
{
    public partial class MyForm : Form
    {
        private Bitmap _bitmap;
        private float _ex = 10f;
        private float _ey = 100f;
        private const float _r = 15f;
        private const float _speed = 5f;

        public MyForm()
        {
            InitializeComponent();

            _bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
        }

        private void MyForm_Paint(object sender, PaintEventArgs e)
        {
            if (_bitmap != null)
            {
                e.Graphics.DrawImage(_bitmap, 0, 0);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            _ex += _speed;
            if (_ex > ClientRectangle.Right)
            {
                _ex = 0;
                _ey += _speed;
            }

            Graphics g = Graphics.FromImage(_bitmap);
            Draw(g);

            Invalidate();
        }

        private void MyForm_ResizeEnd(object sender, EventArgs e)
        {
            UpdateBitmap();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // WM_SYSCOMMAND
            if (m.Msg == 0x0112)
            {
                if (m.WParam == new IntPtr(0xF030) // Maximize event - SC_MAXIMIZE from Winuser.h
                    || m.WParam == new IntPtr(0xF120)) // Restore event - SC_RESTORE from Winuser.h
                {
                    UpdateBitmap();
                }
            }
        }

        private void UpdateBitmap()
        {
            _bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);

            Graphics g = Graphics.FromImage(_bitmap);
            Draw(g);

            Invalidate();
            GC.Collect();
        }

        private void Draw(Graphics graphics)
        {
            graphics.Clear(SystemColors.Window);

            for (int x = 0; x < ClientRectangle.Right; x += 10)
            {
                graphics.DrawLine(Pens.Black, x, 0, x, ClientRectangle.Bottom);
            }

            for (int y = 0; y < ClientRectangle.Bottom; y += 10)
            {
                graphics.DrawLine(Pens.Black, 0, y, ClientRectangle.Right, y);
            }

            graphics.FillEllipse(new SolidBrush(Color.Blue), _ex - _r, _ey - _r, _r * 2, _r * 2);
            graphics.DrawEllipse(new Pen(Color.Black, 5), _ex - _r, _ey - _r, _r * 2, _r * 2);
        }
    }
}
