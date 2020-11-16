using System.Drawing;
using System.Windows.Forms;

namespace TextExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawString("This is first sentense", Font, Brushes.Black, 10, 100);

            //Rectangle rect = new Rectangle(10, 10, 100, 100);
            //e.Graphics.DrawRectangle(Pens.Black, rect);
            //e.Graphics.DrawString("aaaaaaaaaaaaaaaasdfsadfsdfsdafsdafdsafasdfefef", Font, Brushes.Black, rect);

            // Alignment
            //StringFormat format = new StringFormat
            //{
            //    Alignment = StringAlignment.Center
            //};
            //e.Graphics.DrawString("청강문화산업대학교", Font, Brushes.Black, 100, 100, format);

            // Hotkey
            //StringFormat hotkeyFormat = new StringFormat 
            //{ 
            //    Alignment = StringAlignment.Near,
            //    HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            //};

            //e.Graphics.DrawString("&Close", Font, Brushes.Black, 100, 100, hotkeyFormat);

            // Font
            //Font font1 = new Font("궁서", 20, FontStyle.Bold | FontStyle.Italic);
            //e.Graphics.DrawString("청강대학교", font1, Brushes.Black, 10, 10);

            //FontFamily fontFamily = new FontFamily("궁서");
            //Font font2 = new Font(fontFamily, 20);
            //e.Graphics.DrawString("청강대학교", font2, Brushes.Black, 10, 50); 

            Font font3 = new Font("궁서", 30);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.DrawString("청강대학교", font3, Brushes.Black, 10, 10);
        }
    }
}
