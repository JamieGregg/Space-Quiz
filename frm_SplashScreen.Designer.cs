namespace SpaceQuiz
{
    partial class frm_SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SplashScreen));
            this.pgb_splash = new System.Windows.Forms.ProgressBar();
            this.tim_splash = new System.Windows.Forms.Timer(this.components);
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_loadingMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgb_splash
            // 
            this.pgb_splash.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pgb_splash.Location = new System.Drawing.Point(173, 277);
            this.pgb_splash.Name = "pgb_splash";
            this.pgb_splash.Size = new System.Drawing.Size(364, 34);
            this.pgb_splash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_splash.TabIndex = 0;
            this.pgb_splash.Click += new System.EventHandler(this.pgb_splash_Click);
            // 
            // tim_splash
            // 
            this.tim_splash.Enabled = true;
            this.tim_splash.Interval = 10;
            this.tim_splash.Tick += new System.EventHandler(this.tim_Splash_Tick);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Humblle Rought All Caps", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_title.Location = new System.Drawing.Point(208, -11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(280, 83);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Space Quiz";
            // 
            // lbl_loadingMsg
            // 
            this.lbl_loadingMsg.AutoSize = true;
            this.lbl_loadingMsg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loadingMsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loadingMsg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_loadingMsg.Location = new System.Drawing.Point(277, 323);
            this.lbl_loadingMsg.Name = "lbl_loadingMsg";
            this.lbl_loadingMsg.Size = new System.Drawing.Size(84, 21);
            this.lbl_loadingMsg.TabIndex = 2;
            this.lbl_loadingMsg.Text = "Loading...";
            // 
            // frm_SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.lbl_loadingMsg);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pgb_splash);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Quiz";
            this.Load += new System.EventHandler(this.frm_SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgb_splash;
        private System.Windows.Forms.Timer tim_splash;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_loadingMsg;


    }
}

