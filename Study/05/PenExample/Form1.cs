using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PenExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Pen p1 = new Pen(Color.FromArgb(0, 0, 255), 5);

            //for (int i = 0; i < 10; i++)
            //{
            //    p1.Width = i;
            //    e.Graphics.DrawLine(p1, 10, 10 + i * 20, 300, 10 + i * 20);
            //}

            p1.DashStyle = DashStyle.Dash;
            p1.StartCap = p1.EndCap = LineCap.Round;
            e.Graphics.DrawLine(p1, 10, 10, 300, 10);

            p1.DashStyle = DashStyle.Dot;
            p1.StartCap = p1.EndCap = LineCap.Square;
            e.Graphics.DrawLine(p1, 10, 50, 300, 50);

            p1.DashStyle = DashStyle.DashDot;
            p1.StartCap = p1.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(p1, 10, 100, 300, 100);

            p1.DashStyle = DashStyle.DashDotDot;
            p1.StartCap = p1.EndCap = LineCap.RoundAnchor;
            e.Graphics.DrawLine(p1, 10, 150, 300, 150);

            p1.DashStyle = DashStyle.Solid;
            p1.StartCap = p1.EndCap = LineCap.DiamondAnchor;
            e.Graphics.DrawLine(p1, 10, 150, 300, 150);

            //p1.DashStyle = DashStyle.Custom;
            //p1.DashPattern = new float[] { 5, 5, 15, 5, 20, 5}; // 홀수번째는 빈칸 길이
            //e.Graphics.DrawLine(p1, 10, 110, 300, 110);
        }
    }
}
