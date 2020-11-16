using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingPractice
{
    public partial class MainForm : Form
    {
        private readonly Stack<Point> _points = new Stack<Point>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            switch (_points.Count)
            {
                case 0:
                case 1:
                    break;
                case 2:
                    var pointsArray = _points.ToArray();
                    e.Graphics.DrawLine(Pens.Green, pointsArray[0], pointsArray[1]);
                    break;
                default:
                    e.Graphics.FillPolygon(Brushes.Green, _points.ToArray());
                    break;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    _points.Push(new Point(e.X, e.Y));
                    Invalidate();
                    break;
                case MouseButtons.Right:
                    if (_points.Count > 0)
                    {
                        _points.Pop();
                    }
                    Invalidate();
                    break;
                default:
                    break;
            }
        }
    }
}
