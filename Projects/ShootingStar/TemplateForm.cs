using System;
using System.Drawing;
using System.Windows.Forms;
using ShootingStar.Game;

namespace ShootingStar
{
    public partial class TemplateForm : Form
    {
        private readonly Bitmap _buffer;
        private readonly Graphics _graphics;

        public TemplateForm()
        {
            InitializeComponent();

            _buffer = new Bitmap(ClientSize.Width, ClientSize.Height);
            _graphics = Graphics.FromImage(_buffer);
            _graphics.Clear(Color.Blue);
            GlobalBackground.Instance.Draw(_graphics);
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            Invalidate();
            tickTimer.Start();
        }

        private void TemplateForm_Paint(object sender, PaintEventArgs e)
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
    }
}
