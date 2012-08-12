namespace Video_System_Ultimate
{
    partial class Frm_Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Splash));
            this.FS_Timer = new System.Windows.Forms.Timer(this.components);
            this.FS_Progress1 = new System.Windows.Forms.ProgressBar();
            this.FS_IMG1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FS_IMG1)).BeginInit();
            this.SuspendLayout();
            // 
            // FS_Timer
            // 
            this.FS_Timer.Enabled = true;
            this.FS_Timer.Tick += new System.EventHandler(this.S_Timer_Tick);
            // 
            // FS_Progress1
            // 
            this.FS_Progress1.Location = new System.Drawing.Point(-5, 280);
            this.FS_Progress1.Name = "FS_Progress1";
            this.FS_Progress1.Size = new System.Drawing.Size(460, 20);
            this.FS_Progress1.TabIndex = 0;
            // 
            // FS_IMG1
            // 
            this.FS_IMG1.Image = ((System.Drawing.Image)(resources.GetObject("FS_IMG1.Image")));
            this.FS_IMG1.Location = new System.Drawing.Point(0, 0);
            this.FS_IMG1.Name = "FS_IMG1";
            this.FS_IMG1.Size = new System.Drawing.Size(450, 280);
            this.FS_IMG1.TabIndex = 1;
            this.FS_IMG1.TabStop = false;
            // 
            // Frm_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.FS_IMG1);
            this.Controls.Add(this.FS_Progress1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Splash";
            ((System.ComponentModel.ISupportInitialize)(this.FS_IMG1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer FS_Timer;
        private System.Windows.Forms.ProgressBar FS_Progress1;
        private System.Windows.Forms.PictureBox FS_IMG1;
    }
}