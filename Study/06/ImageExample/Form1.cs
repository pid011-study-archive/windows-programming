using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageExample
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;

        public Form1()
        {
            InitializeComponent();
            _bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Image image = Image.FromFile("image.png");
            //e.Graphics.DrawImage(image, 0, 0);
            //e.Graphics.DrawImage(image, new Point(10, 10));
            //e.Graphics.DrawImage(image, new Rectangle(10, 10, 200, 200));
            //e.Graphics.DrawImage(image, new Rectangle(10, 10, image.Width / 2, image.Height / 2));
            //e.Graphics.DrawImage(image, 10, 10, 150, 200);
            //e.Graphics.DrawImage(image, 10, 10, new Rectangle(10, 10, 150, 200), GraphicsUnit.Pixel); // 영역 자르기
            //Rectangle r = new Rectangle(100, 100, 200, 200);
            //Point[] pts =
            //{
            //    new Point(0, 0),
            //    new Point(200, 0),
            //    new Point(100, 300)
            //};
            //e.Graphics.DrawImage(image, pts, r, GraphicsUnit.Pixel);

            e.Graphics.DrawImage(_bitmap, 0, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(_bitmap);
                g.Clear(BackColor);
                Random r = new Random();
                for (int i = 0; i < 500; i++)
                {
                    SolidBrush b = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
                    g.FillEllipse(b, r.Next(ClientSize.Width), r.Next(ClientSize.Height), r.Next(50) + 10, r.Next(50) + 10);
                }

                Invalidate();
            }
        }
    }
}
