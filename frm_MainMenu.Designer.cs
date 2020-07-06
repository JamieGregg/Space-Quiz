namespace SpaceQuiz
{
    partial class frm_MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainMenu));
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.btn_easy = new System.Windows.Forms.Button();
            this.btn_medium = new System.Windows.Forms.Button();
            this.btn_hard = new System.Windows.Forms.Button();
            this.lbl_pointsMessage = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_highscore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Humblle Rought All Caps", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_title.Location = new System.Drawing.Point(179, 6);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(326, 83);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Space Quiz";
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainMenu.Location = new System.Drawing.Point(225, 283);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(205, 45);
            this.btn_mainMenu.TabIndex = 6;
            this.btn_mainMenu.Text = "High Scores";
            this.btn_mainMenu.UseVisualStyleBackColor = true;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // btn_easy
            // 
            this.btn_easy.FlatAppearance.BorderSize = 0;
            this.btn_easy.Image = ((System.Drawing.Image)(resources.GetObject("btn_easy.Image")));
            this.btn_easy.Location = new System.Drawing.Point(160, 86);
            this.btn_easy.Margin = new System.Windows.Forms.Padding(0);
            this.btn_easy.Name = "btn_easy";
            this.btn_easy.Size = new System.Drawing.Size(105, 175);
            this.btn_easy.TabIndex = 7;
            this.btn_easy.UseVisualStyleBackColor = true;
            this.btn_easy.Click += new System.EventHandler(this.btn_easy_Click);
            this.btn_easy.MouseLeave += new System.EventHandler(this.btn_easy_MouseLeave);
            this.btn_easy.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btn_medium
            // 
            this.btn_medium.Image = ((System.Drawing.Image)(resources.GetObject("btn_medium.Image")));
            this.btn_medium.Location = new System.Drawing.Point(280, 86);
            this.btn_medium.Name = "btn_medium";
            this.btn_medium.Size = new System.Drawing.Size(105, 175);
            this.btn_medium.TabIndex = 8;
            this.btn_medium.UseVisualStyleBackColor = true;
            this.btn_medium.Click += new System.EventHandler(this.btn_Medium_Click);
            this.btn_medium.MouseEnter += new System.EventHandler(this.btn_medium_MouseEnter);
            this.btn_medium.MouseLeave += new System.EventHandler(this.btn_medium_MouseLeave);
            // 
            // btn_hard
            // 
            this.btn_hard.Image = ((System.Drawing.Image)(resources.GetObject("btn_hard.Image")));
            this.btn_hard.Location = new System.Drawing.Point(400, 86);
            this.btn_hard.Name = "btn_hard";
            this.btn_hard.Size = new System.Drawing.Size(105, 175);
            this.btn_hard.TabIndex = 9;
            this.btn_hard.UseVisualStyleBackColor = true;
            this.btn_hard.Click += new System.EventHandler(this.btn_hard_Click_1);
            this.btn_hard.MouseEnter += new System.EventHandler(this.btn_hard_MouseEnter);
            this.btn_hard.MouseLeave += new System.EventHandler(this.btn_hard_MouseLeave);
            // 
            // lbl_pointsMessage
            // 
            this.lbl_pointsMessage.AutoSize = true;
            this.lbl_pointsMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pointsMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pointsMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_pointsMessage.Location = new System.Drawing.Point(212, 327);
            this.lbl_pointsMessage.Name = "lbl_pointsMessage";
            this.lbl_pointsMessage.Size = new System.Drawing.Size(0, 25);
            this.lbl_pointsMessage.TabIndex = 10;
            this.lbl_pointsMessage.Visible = false;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_user.Location = new System.Drawing.Point(47, 6);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(44, 20);
            this.lbl_user.TabIndex = 12;
            this.lbl_user.Text = "Error";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Highscore:";
            // 
            // lbl_highscore
            // 
            this.lbl_highscore.AutoSize = true;
            this.lbl_highscore.BackColor = System.Drawing.Color.Transparent;
            this.lbl_highscore.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_highscore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_highscore.Location = new System.Drawing.Point(84, 23);
            this.lbl_highscore.Name = "lbl_highscore";
            this.lbl_highscore.Size = new System.Drawing.Size(44, 20);
            this.lbl_highscore.TabIndex = 15;
            this.lbl_highscore.Text = "Error";
            this.lbl_highscore.Click += new System.EventHandler(this.lbl_highscore_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frm_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_highscore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_pointsMessage);
            this.Controls.Add(this.btn_hard);
            this.Controls.Add(this.btn_medium);
            this.Controls.Add(this.btn_easy);
            this.Controls.Add(this.btn_mainMenu);
            this.Controls.Add(this.lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Quiz";
            this.Load += new System.EventHandler(this.frm_MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Button btn_easy;
        private System.Windows.Forms.Button btn_medium;
        private System.Windows.Forms.Button btn_hard;
        private System.Windows.Forms.Label lbl_pointsMessage;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_highscore;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}