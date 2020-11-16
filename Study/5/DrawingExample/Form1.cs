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
            //var pts = new Point[3];
            //pts[0] = new Point(10, 10);
            //pts[1] = new Point(100, 100);
            //pts[2] = new Point(50, 150);

            //e.Graphics.FillPolygon(Brushes.Red, pts);
            //e.Graphics.DrawPolygon(Pens.Black, pts);

            //e.Graphics.DrawArc(Pens.Black, new Rectangle(10, 10, 100, 50), 0, 360);
            //e.Graphics.DrawPie(Pens.Blue, new Rectangle(200, 10, 100, 100), 0, 120);
            //e.Graphics.FillPie(Brushes.Red, new Rectangle(10, 200, 100, 100), 20, -75);

            //e.Graphics.DrawBezier(Pens.Black, new Point(0, 0), new Point(350, 50), new Point(50, 350), new Point(500, 500));

            Point[] pts2 = new Point[4]
            {
                new Point(10, 10),
                new Point(100, 100),
                new Point(20, 150),
                new Point(200, 40)
            };

            //e.Graphics.DrawCurve(Pens.Red, pts2, tension: 2f);
            e.Graphics.FillClosedCurve(Brushes.Red, pts2, System.Drawing.Drawing2D.FillMode.Winding);
        }
    }
}
