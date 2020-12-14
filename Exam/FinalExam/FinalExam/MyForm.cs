using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        #region Problem 1

        private void listView1AddButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(listView1InputBox.Text);
            listView1InputBox.Clear();
        }

        private void listView2AddButton_Click(object sender, EventArgs e)
        {
            listView2.Items.Add(listView2InputBox.Text);
            listView2InputBox.Clear();
        }

        private void leftToRightButton_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                return;
            }
            var item = listView1.Items[0];
            listView1.Items.RemoveAt(0);
            listView2.Items.Add(item);
        }

        private void rightToLeftButton_Click(object sender, EventArgs e)
        {
            if (listView2.Items.Count == 0)
            {
                return;
            }
            var item = listView2.Items[0];
            listView2.Items.RemoveAt(0);
            listView1.Items.Add(item);
        }

        #endregion

        #region Problem 2

        private void backgroundColorButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ChangeColor(problem2, (string)e.ClickedItem.Tag);
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (sender is ContextMenuStrip owner && owner.SourceControl != null)
            {
                ChangeColor(owner.SourceControl, (string)e.ClickedItem.Tag);
            }
        }

        private void ChangeColor(Control control, string tag)
        {
            switch (tag)
            {
                case "red":
                    control.BackColor = Color.Red;
                    break;

                case "yellow":
                    control.BackColor = Color.Yellow;
                    break;

                case "blue":
                    control.BackColor = Color.Blue;
                    break;

                default:
                    break;
            }
        }

        #endregion

        #region Problem 3

        private const float DefaultFontSize = 10f;

        private void fontSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            var font = fontPreviewLabel.Font.FontFamily;
            fontPreviewLabel.Font.Dispose();
            fontPreviewLabel.Font = new Font(font, DefaultFontSize + fontSizeTrackBar.Value);
        }

        #endregion

        private void getFontButton_Click(object sender, EventArgs e)
        {
            using (var selectForm = new FontSelectForm())
            {
                selectForm.ShowDialog();

                if (selectForm.DialogResult == DialogResult.OK)
                {
                    fontPreviewLabel.Font = new Font(selectForm.SelectedFont, fontPreviewLabel.Font.Size);
                }
            }
        }
    }
}
