using System;
using System.Drawing;
using System.Windows.Forms;
using ShootingStar.Game;

namespace ShootingStar.Forms
{
    public partial class MainMenuForm : Form
    {
        private readonly Bitmap _buffer;
        private readonly Graphics _graphics;

        public MainMenuForm()
        {
            InitializeComponent();

            _buffer = new Bitmap(ClientSize.Width, ClientSize.Height);
            _graphics = Graphics.FromImage(_buffer);
            _graphics.Clear(Color.Blue);
            GlobalBackground.Instance.Draw(_graphics);

            title.Font = new Font(CustomFont.NeoDgmPro, 32);
            startButton.Font = new Font(CustomFont.NeoDgmPro, 16);
            helpButton.Font = new Font(CustomFont.NeoDgmPro, 16);
            exitButton.Font = new Font(CustomFont.NeoDgmPro, 16);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Invalidate();
            tickTimer.Start();
        }

        private void MainMenu_Paint(object sender, PaintEventArgs e)
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

        private void startButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetForm<GameForm>();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetForm<HelpForm>();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
