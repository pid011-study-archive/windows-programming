using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MouseExample
{
    public partial class Form1 : Form
    {
        private (int x, int y) _cursor = (0, 0);

        public Form1()
        {
            InitializeComponent();
            // Cursor.Hide();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Invalidate();
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {

        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Invalidate();
            }
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Invalidate();
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics graphics = CreateGraphics())
                {
                    graphics.DrawLine(Pens.Black, _cursor.x, _cursor.y, e.X, e.Y);
                    _cursor.x = e.X;
                    _cursor.y = e.Y;
                }
                Invalidate();
            }
        }

        private void OnMouseEnter(object sender, System.EventArgs e)
        {
            Text = "Mouse Enter";
        }

        private void OnMouseLeave(object sender, System.EventArgs e)
        {
            Text = "Mouse Leave";
        }
    }
}
