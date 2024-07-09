namespace ANSv1
{
    partial class Splash
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
            this.Splash_progressBar_loading = new MetroFramework.Controls.MetroProgressBar();
            this.Splash_lbl_version = new MetroFramework.Controls.MetroLabel();
            this.Splash_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Splash_progressBar_loading
            // 
            this.Splash_progressBar_loading.Location = new System.Drawing.Point(27, 62);
            this.Splash_progressBar_loading.Name = "Splash_progressBar_loading";
            this.Splash_progressBar_loading.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Splash_progressBar_loading.Size = new System.Drawing.Size(339, 18);
            this.Splash_progressBar_loading.Style = MetroFramework.MetroColorStyle.Green;
            this.Splash_progressBar_loading.TabIndex = 1;
            // 
            // Splash_lbl_version
            // 
            this.Splash_lbl_version.AutoSize = true;
            this.Splash_lbl_version.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Splash_lbl_version.Location = new System.Drawing.Point(287, 89);
            this.Splash_lbl_version.Name = "Splash_lbl_version";
            this.Splash_lbl_version.Size = new System.Drawing.Size(86, 19);
            this.Splash_lbl_version.TabIndex = 2;
            this.Splash_lbl_version.Text = "Version 0.01";
            // 
            // Splash_timer
            // 
            this.Splash_timer.Enabled = true;
            this.Splash_timer.Interval = 1000;
            this.Splash_timer.Tick += new System.EventHandler(this.Splash_timer_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 118);
            this.Controls.Add(this.Splash_lbl_version);
            this.Controls.Add(this.Splash_progressBar_loading);
            this.MaximizeBox = false;
            this.Name = "Splash";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Loading...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar Splash_progressBar_loading;
        private MetroFramework.Controls.MetroLabel Splash_lbl_version;
        private System.Windows.Forms.Timer Splash_timer;
    }
}