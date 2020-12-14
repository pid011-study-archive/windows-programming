
namespace FinalExam
{
    partial class MyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.problem1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.leftToRightButton = new System.Windows.Forms.Button();
            this.rightToLeftButton = new System.Windows.Forms.Button();
            this.listView1InputBox = new System.Windows.Forms.TextBox();
            this.listView1AddButton = new System.Windows.Forms.Button();
            this.listView2InputBox = new System.Windows.Forms.TextBox();
            this.listView2AddButton = new System.Windows.Forms.Button();
            this.problem2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.problem3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.fontSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.fontPreviewLabel = new System.Windows.Forms.Label();
            this.getFontButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.problem1.SuspendLayout();
            this.problem2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.problem3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.problem1);
            this.tabControl1.Controls.Add(this.problem2);
            this.tabControl1.Controls.Add(this.problem3);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.MaximumSize = new System.Drawing.Size(754, 636);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 636);
            this.tabControl1.TabIndex = 0;
            // 
            // problem1
            // 
            this.problem1.Controls.Add(this.listView1);
            this.problem1.Controls.Add(this.listView2);
            this.problem1.Controls.Add(this.leftToRightButton);
            this.problem1.Controls.Add(this.rightToLeftButton);
            this.problem1.Controls.Add(this.listView1InputBox);
            this.problem1.Controls.Add(this.listView1AddButton);
            this.problem1.Controls.Add(this.listView2InputBox);
            this.problem1.Controls.Add(this.listView2AddButton);
            this.problem1.Location = new System.Drawing.Point(4, 24);
            this.problem1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.problem1.Name = "problem1";
            this.problem1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.problem1.Size = new System.Drawing.Size(746, 608);
            this.problem1.TabIndex = 0;
            this.problem1.Text = "문제1";
            this.problem1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(60, 62);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(233, 406);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(452, 62);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(233, 406);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // leftToRightButton
            // 
            this.leftToRightButton.Location = new System.Drawing.Point(334, 224);
            this.leftToRightButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftToRightButton.Name = "leftToRightButton";
            this.leftToRightButton.Size = new System.Drawing.Size(75, 27);
            this.leftToRightButton.TabIndex = 1;
            this.leftToRightButton.Text = "->";
            this.leftToRightButton.UseVisualStyleBackColor = true;
            this.leftToRightButton.Click += new System.EventHandler(this.leftToRightButton_Click);
            // 
            // rightToLeftButton
            // 
            this.rightToLeftButton.Location = new System.Drawing.Point(334, 276);
            this.rightToLeftButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rightToLeftButton.Name = "rightToLeftButton";
            this.rightToLeftButton.Size = new System.Drawing.Size(75, 26);
            this.rightToLeftButton.TabIndex = 1;
            this.rightToLeftButton.Text = "<-";
            this.rightToLeftButton.UseVisualStyleBackColor = true;
            this.rightToLeftButton.Click += new System.EventHandler(this.rightToLeftButton_Click);
            // 
            // listView1InputBox
            // 
            this.listView1InputBox.Location = new System.Drawing.Point(60, 518);
            this.listView1InputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1InputBox.Name = "listView1InputBox";
            this.listView1InputBox.Size = new System.Drawing.Size(142, 23);
            this.listView1InputBox.TabIndex = 2;
            // 
            // listView1AddButton
            // 
            this.listView1AddButton.Location = new System.Drawing.Point(218, 518);
            this.listView1AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1AddButton.Name = "listView1AddButton";
            this.listView1AddButton.Size = new System.Drawing.Size(75, 23);
            this.listView1AddButton.TabIndex = 3;
            this.listView1AddButton.Text = "추가";
            this.listView1AddButton.UseVisualStyleBackColor = true;
            this.listView1AddButton.Click += new System.EventHandler(this.listView1AddButton_Click);
            // 
            // listView2InputBox
            // 
            this.listView2InputBox.Location = new System.Drawing.Point(452, 515);
            this.listView2InputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView2InputBox.Name = "listView2InputBox";
            this.listView2InputBox.Size = new System.Drawing.Size(142, 23);
            this.listView2InputBox.TabIndex = 2;
            // 
            // listView2AddButton
            // 
            this.listView2AddButton.Location = new System.Drawing.Point(610, 515);
            this.listView2AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView2AddButton.Name = "listView2AddButton";
            this.listView2AddButton.Size = new System.Drawing.Size(75, 23);
            this.listView2AddButton.TabIndex = 3;
            this.listView2AddButton.Text = "추가";
            this.listView2AddButton.UseVisualStyleBackColor = true;
            this.listView2AddButton.Click += new System.EventHandler(this.listView2AddButton_Click);
            // 
            // problem2
            // 
            this.problem2.Controls.Add(this.panel2);
            this.problem2.Controls.Add(this.panel1);
            this.problem2.Controls.Add(this.toolStrip1);
            this.problem2.Location = new System.Drawing.Point(4, 24);
            this.problem2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.problem2.Name = "problem2";
            this.problem2.Size = new System.Drawing.Size(746, 608);
            this.problem2.TabIndex = 1;
            this.problem2.Text = "문제2";
            this.problem2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ContextMenuStrip = this.contextMenuStrip1;
            this.panel2.Location = new System.Drawing.Point(389, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 354);
            this.panel2.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.OwnerItem = this.backgroundColorButton;
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 70);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem1.Tag = "red";
            this.toolStripMenuItem1.Text = "빨강";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem2.Tag = "yellow";
            this.toolStripMenuItem2.Text = "노랑";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem3.Tag = "blue";
            this.toolStripMenuItem3.Text = "파랑";
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.backgroundColorButton.DropDown = this.contextMenuStrip1;
            this.backgroundColorButton.Image = ((System.Drawing.Image)(resources.GetObject("backgroundColorButton.Image")));
            this.backgroundColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.ShowDropDownArrow = false;
            this.backgroundColorButton.Size = new System.Drawing.Size(63, 22);
            this.backgroundColorButton.Text = "배경 색상";
            this.backgroundColorButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.backgroundColorButton_DropDownItemClicked);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Location = new System.Drawing.Point(82, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 354);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(746, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // problem3
            // 
            this.problem3.Controls.Add(this.label1);
            this.problem3.Controls.Add(this.fontSizeTrackBar);
            this.problem3.Controls.Add(this.fontPreviewLabel);
            this.problem3.Controls.Add(this.getFontButton);
            this.problem3.Location = new System.Drawing.Point(4, 24);
            this.problem3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.problem3.Name = "problem3";
            this.problem3.Size = new System.Drawing.Size(746, 608);
            this.problem3.TabIndex = 2;
            this.problem3.Text = "문제3";
            this.problem3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "폰트 사이즈";
            // 
            // fontSizeTrackBar
            // 
            this.fontSizeTrackBar.Location = new System.Drawing.Point(274, 420);
            this.fontSizeTrackBar.Maximum = 50;
            this.fontSizeTrackBar.Name = "fontSizeTrackBar";
            this.fontSizeTrackBar.Size = new System.Drawing.Size(273, 45);
            this.fontSizeTrackBar.TabIndex = 2;
            this.fontSizeTrackBar.Scroll += new System.EventHandler(this.fontSizeTrackBar_Scroll);
            // 
            // fontPreviewLabel
            // 
            this.fontPreviewLabel.AutoSize = true;
            this.fontPreviewLabel.Location = new System.Drawing.Point(3, 10);
            this.fontPreviewLabel.Name = "fontPreviewLabel";
            this.fontPreviewLabel.Size = new System.Drawing.Size(189, 15);
            this.fontPreviewLabel.TabIndex = 0;
            this.fontPreviewLabel.Text = "Today is Exam Day! Do your best!";
            // 
            // getFontButton
            // 
            this.getFontButton.Location = new System.Drawing.Point(309, 306);
            this.getFontButton.Name = "getFontButton";
            this.getFontButton.Size = new System.Drawing.Size(161, 48);
            this.getFontButton.TabIndex = 1;
            this.getFontButton.Text = "폰트 가져오기";
            this.getFontButton.UseVisualStyleBackColor = true;
            this.getFontButton.Click += new System.EventHandler(this.getFontButton_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 661);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(790, 700);
            this.Name = "MyForm";
            this.Text = "기말고사 곽필경 E반 202013128";
            this.tabControl1.ResumeLayout(false);
            this.problem1.ResumeLayout(false);
            this.problem1.PerformLayout();
            this.problem2.ResumeLayout(false);
            this.problem2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.problem3.ResumeLayout(false);
            this.problem3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage problem1;
        private System.Windows.Forms.Button listView2AddButton;
        private System.Windows.Forms.TextBox listView2InputBox;
        private System.Windows.Forms.Button listView1AddButton;
        private System.Windows.Forms.TextBox listView1InputBox;
        private System.Windows.Forms.Button rightToLeftButton;
        private System.Windows.Forms.Button leftToRightButton;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage problem2;
        private System.Windows.Forms.TabPage problem3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripDropDownButton backgroundColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar fontSizeTrackBar;
        private System.Windows.Forms.Label fontPreviewLabel;
        private System.Windows.Forms.Button getFontButton;
    }
}

