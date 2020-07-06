namespace SpaceQuiz
{
    partial class frm_Congratulations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Congratulations));
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.btn_highScores = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_scoreTitle = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_playerUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_mainMenu.Location = new System.Drawing.Point(165, 298);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(185, 51);
            this.btn_mainMenu.TabIndex = 0;
            this.btn_mainMenu.Text = "Main Menu";
            this.btn_mainMenu.UseVisualStyleBackColor = true;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // btn_highScores
            // 
            this.btn_highScores.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_highScores.Location = new System.Drawing.Point(375, 298);
            this.btn_highScores.Name = "btn_highScores";
            this.btn_highScores.Size = new System.Drawing.Size(181, 51);
            this.btn_highScores.TabIndex = 1;
            this.btn_highScores.Text = "High Scores";
            this.btn_highScores.UseVisualStyleBackColor = true;
            this.btn_highScores.Click += new System.EventHandler(this.btn_highScores_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_title.Location = new System.Drawing.Point(140, -3);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(422, 63);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Congratulations";
            // 
            // lbl_scoreTitle
            // 
            this.lbl_scoreTitle.AutoSize = true;
            this.lbl_scoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_scoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_scoreTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_scoreTitle.Location = new System.Drawing.Point(204, 145);
            this.lbl_scoreTitle.Name = "lbl_scoreTitle";
            this.lbl_scoreTitle.Size = new System.Drawing.Size(245, 46);
            this.lbl_scoreTitle.TabIndex = 4;
            this.lbl_scoreTitle.Text = "You scored:";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.lbl_score.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_score.Location = new System.Drawing.Point(427, 141);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(58, 54);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "C";
            this.lbl_score.Click += new System.EventHandler(this.lbl_score_Click);
            // 
            // lbl_playerUsername
            // 
            this.lbl_playerUsername.AutoSize = true;
            this.lbl_playerUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbl_playerUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_playerUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_playerUsername.Location = new System.Drawing.Point(239, 61);
            this.lbl_playerUsername.Name = "lbl_playerUsername";
            this.lbl_playerUsername.Size = new System.Drawing.Size(211, 46);
            this.lbl_playerUsername.TabIndex = 6;
            this.lbl_playerUsername.Text = "Username";
            this.lbl_playerUsername.Click += new System.EventHandler(this.lbl_playerUsername_Click);
            // 
            // frm_Congratulations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.lbl_playerUsername);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_scoreTitle);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_highScores);
            this.Controls.Add(this.btn_mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Congratulations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Quiz";
            this.Load += new System.EventHandler(this.frm_Congratulations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Button btn_highScores;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_scoreTitle;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_playerUsername;
    }
}