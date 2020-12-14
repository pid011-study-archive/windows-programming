using System;
using System.Drawing;
using System.Windows.Forms;
using ShootingStar.Game;

namespace ShootingStar.Forms
{
    public partial class HelpForm : Form
    {
        private readonly Bitmap _buffer;
        private readonly Graphics _graphics;

        public HelpForm()
        {
            InitializeComponent();

            _buffer = new Bitmap(ClientSize.Width, ClientSize.Height);
            _graphics = Graphics.FromImage(_buffer);
            _graphics.Clear(Color.Blue);
            GlobalBackground.Instance.Draw(_graphics);

            descLabel1.Font = new Font(CustomFont.NeoDgmPro, 16);
            descLabel2.Font = new Font(CustomFont.NeoDgmPro, 16);
            descLabel3.Font = new Font(CustomFont.NeoDgmPro, 16);
            mainMenuButton.Font = new Font(CustomFont.NeoDgmPro, 16);
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            Invalidate();
            tickTimer.Start();
        }

        private void HelpForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(_buffer, 0, 0);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            _graphics.Clear(Color.Blue);
            GlobalBackground.Instance.Update();
            GlobalBackground.Instance.Draw(_graphics);
            Invalidate();
        }

        private void HelpForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainForm.Instance.SetForm<MainMenuForm>();
            }
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetForm<MainMenuForm>();
        }
    }
}
