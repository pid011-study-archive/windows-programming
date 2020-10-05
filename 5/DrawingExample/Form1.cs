using System.Drawing;
using System.Windows.Forms;

namespace DrawingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var pts = new Point[3];
            pts[0] = new Point(10, 10);
            pts[1] = new Point(100, 100);
            pts[2] = new Point(50, 150);

            e.Graphics.FillPolygon(Brushes.Red, pts);
            e.Graphics.DrawPolygon(Pens.Black, pts);
        }
    }
}
