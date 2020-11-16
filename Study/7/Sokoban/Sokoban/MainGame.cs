using System.Drawing;
using System.Windows.Forms;

namespace Sokoban
{
    public partial class MainGame : Form
    {
        public const int TileSize = 32;

        private readonly Bitmap _bitmap;
        private Stage _currentStage;

        private readonly int[,] _stage1 = new int[,]
        {
            {0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,1,3,0,0,1,0,0,0,0,0,0,0,0,0,0},
            {0,0,1,1,1,0,0,3,1,1,0,0,0,0,0,0,0,0,0},
            {0,0,1,0,0,3,0,3,0,1,0,0,0,0,0,0,0,0,0},
            {1,1,1,0,1,0,1,1,0,1,0,0,0,1,1,1,1,1,1},
            {1,0,0,0,1,0,1,1,0,1,1,1,1,1,0,0,2,2,1},
            {1,0,3,0,0,3,0,0,0,0,0,0,0,0,0,0,2,2,1},
            {1,1,1,1,1,0,1,1,1,0,1,4,1,1,0,0,2,2,1},
            {0,0,0,0,1,0,0,0,0,0,1,1,1,1,1,1,1,1,1},
            {0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0},
        };

        public MainGame()
        {
            InitializeComponent();

            _currentStage = new Stage("Stage 1", _stage1);
            ClientSize = new Size(_currentStage.Size.X * TileSize, _currentStage.Size.Y * TileSize);
            _bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
            using (Graphics g = Graphics.FromImage(_bitmap))
            {
                Draw(g);
                Invalidate();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        private void MainGame_Paint(object sender, PaintEventArgs e)
        {
            if (_bitmap != null)
            {
                e.Graphics.DrawImage(_bitmap, 0, 0);
            }
        }

        private void MainGame_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.R)
                {
                    _currentStage = new Stage("Stage 1", _stage1);
                    return;
                }

                if (_currentStage.IsStageClear)
                {
                    return;
                }

                switch (e.KeyCode)
                {
                    case Keys.Up:
                        _currentStage.MovePlayer(Direction.Up);
                        break;
                    case Keys.Down:
                        _currentStage.MovePlayer(Direction.Down);
                        break;
                    case Keys.Left:
                        _currentStage.MovePlayer(Direction.Left);
                        break;
                    case Keys.Right:
                        _currentStage.MovePlayer(Direction.Right);
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                using (Graphics g = Graphics.FromImage(_bitmap))
                {
                    Draw(g);
                    Invalidate();
                }
            }
        }

        private void Draw(Graphics graphics)
        {
            graphics.Clear(SystemColors.Window);
            _currentStage.Draw(graphics);

            Font uiFont = new Font("Arial", 11, FontStyle.Regular);
            graphics.DrawString("[R] - Restart stage", uiFont, Brushes.Purple, 10, 10);

            graphics.DrawString(
                $"[{_currentStage.StageName}]", 
                uiFont, 
                Brushes.Purple, 
                ClientSize.Width - 10, 
                10,
                new StringFormat
                {
                    Alignment = StringAlignment.Far
                });

            if (_currentStage.IsStageClear)
            {
                Font stageClearFont = new Font("Arial", 20, FontStyle.Bold);
                graphics.DrawString(
                    "Stage clear!",
                    stageClearFont,
                    Brushes.Blue,
                    ClientSize.Width / 2,
                    ClientSize.Height / 2,
                    new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    });
            }
        }
    }
}
