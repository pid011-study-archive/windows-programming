
namespace TreeViewExample
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("강남구");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("서울특별시", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("홍문동");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("여주시", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("대한민국", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("워싱턴DC");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("뉴욕");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("미국", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "Node4";
            treeNode9.Text = "강남구";
            treeNode10.Name = "Node3";
            treeNode10.Text = "서울특별시";
            treeNode11.Name = "Node6";
            treeNode11.Text = "홍문동";
            treeNode12.Name = "Node5";
            treeNode12.Text = "여주시";
            treeNode13.Name = "Node0";
            treeNode13.Text = "대한민국";
            treeNode14.Name = "Node9";
            treeNode14.Text = "워싱턴DC";
            treeNode15.Name = "Node10";
            treeNode15.Text = "뉴욕";
            treeNode16.Name = "Node2";
            treeNode16.Text = "미국";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(440, 299);
            this.treeView1.TabIndex = 0;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(12, 317);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(440, 385);
            this.treeView2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 714);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
    }
}

