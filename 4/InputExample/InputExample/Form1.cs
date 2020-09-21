using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InputExample
{
    public partial class Form1 : Form
    {
        private StringBuilder _inputStr = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                _inputStr = _inputStr.Append(e.KeyChar);
                Invalidate();
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(_inputStr.ToString() + "_", new Font("NanumGothic", 10), Brushes.Black, 10, 10);
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            _inputStr = e.KeyCode switch
            {
                Keys.Enter => _inputStr.AppendLine(),
                Keys.Space => _inputStr.Append(" "),
                Keys.Back => _inputStr.Length > 0 ? _inputStr.Remove(_inputStr.Length - 1, 1) : _inputStr,
                _ => _inputStr
            };

            Invalidate();
        }
    }
}
