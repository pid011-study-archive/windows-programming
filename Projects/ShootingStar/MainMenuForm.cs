﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShootingStar
{
    public partial class MainMenuForm : Form
    {
        private Bitmap _buffer;
        private Graphics _graphics;

        public MainMenuForm()
        {
            InitializeComponent();

            title.Font = new Font(CustomFont.NeoDgm, 32);
            startButton.Font = new Font(CustomFont.NeoDgm, 16);
            helpButton.Font = new Font(CustomFont.NeoDgm, 16);
            exitButton.Font = new Font(CustomFont.NeoDgm, 16);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            _buffer = new Bitmap(ClientSize.Width, ClientSize.Height);
            _graphics = Graphics.FromImage(_buffer);
            _graphics.Clear(Color.Black);
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
            _graphics.Clear(Color.Black);

            Invalidate();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetForm<GameForm>();
        }
    }
}