
namespace ShootingStar.Forms
{
    partial class HelpForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.descLabel3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.descLabel2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.descLabel1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.mainMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // tickTimer
            // 
            this.tickTimer.Interval = 20;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ShootingStar.Properties.Resources.image_enemy0_0;
            this.pictureBox1.Location = new System.Drawing.Point(105, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // descLabel3
            // 
            this.descLabel3.AutoSize = true;
            this.descLabel3.BackColor = System.Drawing.Color.Transparent;
            this.descLabel3.Font = new System.Drawing.Font("NeoDunggeunmo Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.descLabel3.ForeColor = System.Drawing.Color.White;
            this.descLabel3.Location = new System.Drawing.Point(137, 459);
            this.descLabel3.Name = "descLabel3";
            this.descLabel3.Size = new System.Drawing.Size(412, 21);
            this.descLabel3.TabIndex = 1;
            this.descLabel3.Text = "2번 맞아야 죽으며, +2 만큼의 점수를 준다.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ShootingStar.Properties.Resources.image_enemy1_0;
            this.pictureBox2.Location = new System.Drawing.Point(105, 506);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // descLabel2
            // 
            this.descLabel2.AutoSize = true;
            this.descLabel2.BackColor = System.Drawing.Color.Transparent;
            this.descLabel2.Font = new System.Drawing.Font("NeoDunggeunmo Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.descLabel2.ForeColor = System.Drawing.Color.White;
            this.descLabel2.Location = new System.Drawing.Point(137, 505);
            this.descLabel2.Name = "descLabel2";
            this.descLabel2.Size = new System.Drawing.Size(412, 21);
            this.descLabel2.TabIndex = 1;
            this.descLabel2.Text = "1번 맞아야 죽으며, +1 만큼의 점수를 준다.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ShootingStar.Properties.Resources.image_enemy2_0;
            this.pictureBox3.Location = new System.Drawing.Point(69, 506);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // descLabel1
            // 
            this.descLabel1.AutoSize = true;
            this.descLabel1.BackColor = System.Drawing.Color.Transparent;
            this.descLabel1.Font = new System.Drawing.Font("NeoDunggeunmo Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.descLabel1.ForeColor = System.Drawing.Color.White;
            this.descLabel1.Location = new System.Drawing.Point(65, 308);
            this.descLabel1.Name = "descLabel1";
            this.descLabel1.Size = new System.Drawing.Size(374, 63);
            this.descLabel1.TabIndex = 2;
            this.descLabel1.Text = "플레이어의 목숨은 3개.\r\n제한시간동안 적들을 최대한 많이 잡아\r\n높은 점수를 획득하십시오.\r\n";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::ShootingStar.Properties.Resources.image_heart;
            this.pictureBox4.Location = new System.Drawing.Point(105, 273);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::ShootingStar.Properties.Resources.image_fighter0;
            this.pictureBox5.Location = new System.Drawing.Point(69, 273);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::ShootingStar.Properties.Resources.image_heart;
            this.pictureBox6.Location = new System.Drawing.Point(141, 273);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::ShootingStar.Properties.Resources.image_heart;
            this.pictureBox7.Location = new System.Drawing.Point(177, 273);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuButton.Location = new System.Drawing.Point(177, 771);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(250, 50);
            this.mainMenuButton.TabIndex = 4;
            this.mainMenuButton.Text = "처음화면으로";
            this.mainMenuButton.UseVisualStyleBackColor = false;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(634, 861);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.descLabel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.descLabel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.descLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainMenuButton);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HelpForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HelpForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label descLabel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label descLabel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label descLabel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button mainMenuButton;
    }
}
