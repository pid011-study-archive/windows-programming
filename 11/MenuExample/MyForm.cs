using System.Drawing;
using System.Windows.Forms;

namespace MenuExample
{
    public partial class MyForm : Form
    {
        private enum Shape { Circle, Rectangle, Line }

        private int _penWidth = 1;
        private Color _inColor = Color.Yellow;
        private Shape _shape = Shape.Circle;

        public MyForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem_test1_Click(object sender, System.EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            Text = "Menu Item Clicked: " + menuItem.Name;
        }

        private void test2ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            Text = "Menu Item Clicked: " + menuItem.Name;
        }

        private void MyForm_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Black, _penWidth);
            var brush = new SolidBrush(_inColor);

            switch (_shape)
            {
                case Shape.Circle:
                    e.Graphics.FillEllipse(brush, 100, 50, 100, 100);
                    e.Graphics.DrawEllipse(pen, 100, 50, 100, 100);
                    break;
                case Shape.Rectangle:
                    e.Graphics.FillRectangle(brush, 100, 50, 100, 100);
                    e.Graphics.DrawRectangle(pen, 100, 50, 100, 100);
                    break;
                case Shape.Line:
                    e.Graphics.DrawLine(pen, 100, 50, 200, 150);
                    break;
                default:
                    break;
            }
        }

        private void circleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _shape = Shape.Circle;
            Invalidate();
        }

        private void rectangleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _shape = Shape.Rectangle;
            Invalidate();
        }

        private void lineToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _shape = Shape.Line;
            Invalidate();
        }

        private void redToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _inColor = Color.Red;
            Invalidate();
        }

        private void blueToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _inColor = Color.Blue;
            Invalidate();
        }

        private void thickToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _penWidth = _penWidth != 5 ? 5 : 10;
            Invalidate();
        }

        private void menuStrip1_MenuActivate(object sender, System.EventArgs e)
        {
            circleToolStripMenuItem.Checked = (_shape == Shape.Circle);
            rectangleToolStripMenuItem.Checked = (_shape == Shape.Rectangle);
            lineToolStripMenuItem.Checked = (_shape == Shape.Line);

            redToolStripMenuItem.Checked = (_inColor == Color.Red);
            blueToolStripMenuItem.Checked = (_inColor == Color.Blue);

            thickToolStripMenuItem.Checked = (_penWidth == 5);

            redToolStripMenuItem.Enabled = (_shape != Shape.Line);
            blueToolStripMenuItem.Enabled = (_shape != Shape.Line);
        }

        private void MyForm_MouseUp(object sender, MouseEventArgs e)
        {
            // 좌표를 이용하여 수동으로 처리
            if (e.Button == MouseButtons.Right)
            {
                var pt = new Point(e.X, e.Y);
                pt = PointToScreen(pt);

                if (e.X < Width / 2)
                {
                    contextMenuStrip1.Show(pt);
                }
                else
                {
                    contextMenuStrip2.Show(pt);
                }
            }
        }

        private void redBackgroundToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            BackColor = Color.Red;
        }
    }
}
