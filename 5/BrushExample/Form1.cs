using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BrushExample
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //SolidBrush solid = new SolidBrush(Color.Red);
            //e.Graphics.FillEllipse(solid, 10, 10, 20, 20);

            //HatchStyle hs = 0;

            //for (int y = 0; ; y++)
            //{
            //    for (int x = 0; x < 8; x++)
            //    {
            //        HatchBrush hatch = new HatchBrush(hs, GetRandomColor(), GetRandomColor());
            //        e.Graphics.FillRectangle(hatch, x * 70, y * 70, 60, 60);
            //        hs++;

            //        if (hs > (HatchStyle)52)
            //        {
            //            break;
            //        }
            //    }

            //    if (hs > (HatchStyle)52)
            //    {
            //        break;
            //    }
            //}

            //LinearGradientBrush gb = new LinearGradientBrush(new Point(0, 0), new Point(100, 200), Color.Blue, Color.Yellow);
            //e.Graphics.FillRectangle(gb, 0, 0, 300, 300);

            using (Image image = Image.FromFile("image.png"))
            {
                TextureBrush tb = new TextureBrush(image)
                {
                    WrapMode = WrapMode.Clamp
                };
                e.Graphics.FillRectangle(tb, ClientRectangle);
            }
        }

        private Color GetRandomColor() =>
            Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
    }
}
