
namespace ShootingStar
{
    partial class LeaderboardForm
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
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.leaderboardListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scoreColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tickTimer
            // 
            this.tickTimer.Interval = 20;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // leaderboardListView
            // 
            this.leaderboardListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.leaderboardListView.BackColor = System.Drawing.Color.MediumBlue;
            this.leaderboardListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.scoreColumnHeader});
            this.leaderboardListView.Font = new System.Drawing.Font("NeoDunggeunmo Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leaderboardListView.ForeColor = System.Drawing.Color.White;
            this.leaderboardListView.GridLines = true;
            this.leaderboardListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.leaderboardListView.Location = new System.Drawing.Point(115, 129);
            this.leaderboardListView.Name = "leaderboardListView";
            this.leaderboardListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.leaderboardListView.Size = new System.Drawing.Size(404, 484);
            this.leaderboardListView.TabIndex = 0;
            this.leaderboardListView.TabStop = false;
            this.leaderboardListView.UseCompatibleStateImageBehavior = false;
            this.leaderboardListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "이름";
            this.nameColumnHeader.Width = 200;
            // 
            // scoreColumnHeader
            // 
            this.scoreColumnHeader.Text = "점수";
            this.scoreColumnHeader.Width = 200;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("NeoDunggeunmo Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainMenuButton.Location = new System.Drawing.Point(199, 638);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(234, 53);
            this.mainMenuButton.TabIndex = 1;
            this.mainMenuButton.Text = "처음화면으로";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // LeaderboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 861);
            this.Controls.Add(this.leaderboardListView);
            this.Controls.Add(this.mainMenuButton);
            this.Name = "LeaderboardForm";
            this.Text = "LeaderboardForm";
            this.Load += new System.EventHandler(this.LeaderboardForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LeaderboardForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.ListView leaderboardListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader scoreColumnHeader;
        private System.Windows.Forms.Button mainMenuButton;
    }
}
