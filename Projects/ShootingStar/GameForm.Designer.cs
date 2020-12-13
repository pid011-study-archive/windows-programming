namespace ShootingStar
{
    partial class GameForm
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
            if (disposing)
            {
                components?.Dispose();
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
            this.destroyTimer = new System.Windows.Forms.Timer(this.components);
            this.invincibleTimer = new System.Windows.Forms.Timer(this.components);
            this.pausePanel = new System.Windows.Forms.Panel();
            this.resumeButton = new System.Windows.Forms.Button();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.pausePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tickTimer
            // 
            this.tickTimer.Interval = 20;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // invincibleTimer
            // 
            this.invincibleTimer.Interval = 250;
            this.invincibleTimer.Tick += new System.EventHandler(this.invincibleTimer_Tick);
            // 
            // pausePanel
            // 
            this.pausePanel.BackColor = System.Drawing.Color.MediumBlue;
            this.pausePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pausePanel.Controls.Add(this.pauseLabel);
            this.pausePanel.Controls.Add(this.resumeButton);
            this.pausePanel.Controls.Add(this.restartButton);
            this.pausePanel.Controls.Add(this.mainMenuButton);
            this.pausePanel.Location = new System.Drawing.Point(150, 289);
            this.pausePanel.Name = "pausePanel";
            this.pausePanel.Size = new System.Drawing.Size(307, 230);
            this.pausePanel.TabIndex = 0;
            // 
            // resumeButton
            // 
            this.resumeButton.Font = new System.Drawing.Font("NeoDunggeunmo Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resumeButton.Location = new System.Drawing.Point(52, 92);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(200, 37);
            this.resumeButton.TabIndex = 1;
            this.resumeButton.Text = "계속하기";
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // pauseLabel
            // 
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.BackColor = System.Drawing.Color.Transparent;
            this.pauseLabel.Font = new System.Drawing.Font("NeoDunggeunmo Pro", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pauseLabel.ForeColor = System.Drawing.Color.White;
            this.pauseLabel.Location = new System.Drawing.Point(61, 26);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(191, 43);
            this.pauseLabel.TabIndex = 0;
            this.pauseLabel.Text = "일시정지";
            this.pauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("NeoDunggeunmo Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.restartButton.Location = new System.Drawing.Point(52, 135);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(200, 37);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "다시하기";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("NeoDunggeunmo Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainMenuButton.Location = new System.Drawing.Point(52, 178);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(200, 37);
            this.mainMenuButton.TabIndex = 1;
            this.mainMenuButton.Text = "처음화면으로";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 861);
            this.Controls.Add(this.pausePanel);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.pausePanel.ResumeLayout(false);
            this.pausePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.Timer destroyTimer;
        private System.Windows.Forms.Timer invincibleTimer;
        private System.Windows.Forms.Panel pausePanel;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button restartButton;
    }
}

