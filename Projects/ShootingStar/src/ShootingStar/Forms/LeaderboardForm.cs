using System;
using System.Drawing;
using System.Windows.Forms;
using ShootingStar.Game;

namespace ShootingStar.Forms
{
    public partial class LeaderboardForm : Form
    {
        private readonly Bitmap _buffer;
        private readonly Graphics _graphics;

        public LeaderboardForm()
        {
            InitializeComponent();

            _buffer = new Bitmap(ClientSize.Width, ClientSize.Height);
            _graphics = Graphics.FromImage(_buffer);
            _graphics.Clear(Color.Blue);
            GlobalBackground.Instance.Draw(_graphics);

            leaderboardListView.Font = new Font(CustomFont.NeoDgmPro, 16);
            mainMenuButton.Font = new Font(CustomFont.NeoDgmPro, 16);
        }

        private void LeaderboardForm_Load(object sender, EventArgs e)
        {
            Invalidate();
            tickTimer.Start();

            foreach (var item in Leaderboard.Data)
            {
                leaderboardListView.Items.Add(
                    new ListViewItem(new string[] { item.Name, item.Score.ToString() }));
            }
        }

        private void LeaderboardForm_Paint(object sender, PaintEventArgs e)
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

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetForm<MainMenuForm>();
        }
    }
}
