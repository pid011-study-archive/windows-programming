using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class FontSelectForm : Form
    {
        public FontFamily SelectedFont { get; private set; }

        private readonly FontFamily[] _fonts;

        public FontSelectForm()
        {
            InitializeComponent();

            _fonts = FontFamily.Families;

            foreach (var font in _fonts)
            {
                fontListBox.Items.Add(font.Name);
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            SetFont();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fontListBox_DoubleClick(object sender, EventArgs e)
        {
            SetFont();
        }

        private void SetFont()
        {
            if (fontListBox.SelectedItem == null)
            {
                return;
            }
            SelectedFont = _fonts[fontListBox.SelectedIndex];
            DialogResult = DialogResult.OK;
        }
    }
}
