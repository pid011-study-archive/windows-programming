using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ShootingStar.Game;

namespace ShootingStar.Forms
{
    public partial class ScoreForm : Form
    {
        private readonly Bitmap _buffer;
        private readonly Graphics _graphics;

        public ScoreForm()
        {
            InitializeComponent();
            _buffer = new Bitmap(ClientSize.Width, ClientSize.Height);
            _graphics = Graphics.FromImage(_buffer);
            _graphics.Clear(Color.Blue);
            GlobalBackground.Instance.Draw(_graphics);

            scoreLabel.Font = new Font(CustomFont.NeoDgmPro, 32);
            nameInputLabel.Font = new Font(CustomFont.NeoDgmPro, 16);
            nameTextBox.Font = new Font(CustomFont.NeoDgmPro, 16);
            submitButton.Font = new Font(CustomFont.NeoDgmPro, 16);
            mainMenuButton.Font = new Font(CustomFont.NeoDgmPro, 16);

            submitButton.Enabled = false;
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            Invalidate();
            scoreLabel.Text = $"{PlayerData.Score}점";
            tickTimer.Start();
        }

        private void ScoreForm_Paint(object sender, PaintEventArgs e)
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

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidName(nameTextBox.Text))
            {
                nameTextBox.BackColor = Color.Red;
                submitButton.Enabled = false;
            }
            else
            {
                nameTextBox.BackColor = Color.White;
                submitButton.Enabled = true;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Leaderboard.AddPlayer(nameTextBox.Text, PlayerData.Score);
            MainForm.Instance.SetForm<LeaderboardForm>();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetForm<MainMenuForm>();
        }

        private bool IsValidName(string name)
        {
            if (!Regex.IsMatch(name, "^[0-9a-zA-Z가-힣]*$")) // 특수문자 입력 금지
            {
                return false;
            }

            // 한글 2 ~ 6글자
            // 영어 4 ~ 12글자
            // 한글영어 혼합가능
            var count = name.ToCharArray()
                            .Sum(ch => Regex.IsMatch(ch.ToString(), "[0-9a-zA-Z]") ? 1 : 2);

            return count >= 4 && count <= 12;
        }
    }
}
