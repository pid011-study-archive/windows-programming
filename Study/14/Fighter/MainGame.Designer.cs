
namespace Fighter
{
    partial class MainGame
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
            this.SuspendLayout();
            // 
            // tickTimer
            // 
            this.tickTimer.Interval = 20;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 740);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainGame_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tickTimer;
    }
}
