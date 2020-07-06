namespace SpaceQuiz
{
    partial class frm_helpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_helpScreen));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_text = new System.Windows.Forms.Label();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Humblle Rought All Caps", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_title.Location = new System.Drawing.Point(204, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(242, 83);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Welcome!";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.BackColor = System.Drawing.Color.Transparent;
            this.lbl_text.Font = new System.Drawing.Font("Humblle Rought All Caps", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_text.Location = new System.Drawing.Point(66, 98);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(78, 38);
            this.lbl_text.TabIndex = 5;
            this.lbl_text.Text = "label1";
            this.lbl_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_mainMenu.Location = new System.Drawing.Point(236, 298);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(185, 51);
            this.btn_mainMenu.TabIndex = 6;
            this.btn_mainMenu.Text = "Continue";
            this.btn_mainMenu.UseVisualStyleBackColor = true;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // frm_helpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btn_mainMenu);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_helpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Quiz";
            this.Load += new System.EventHandler(this.frm_helpScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Button btn_mainMenu;
    }
}