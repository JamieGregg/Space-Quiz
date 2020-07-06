namespace SpaceQuiz
{
    partial class frm_LogOn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LogOn));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_LogOn = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_showPassword = new System.Windows.Forms.Button();
            this.lbl_usernameError = new System.Windows.Forms.Label();
            this.lbl_passwordError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Humblle Rought All Caps", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_title.Location = new System.Drawing.Point(203, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(182, 83);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Log on";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(56, 131);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(146, 37);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(56, 192);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(139, 37);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_username.Location = new System.Drawing.Point(210, 139);
            this.txt_username.MaxLength = 15;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(286, 25);
            this.txt_username.TabIndex = 5;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(210, 200);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(190, 25);
            this.txt_password.TabIndex = 6;
            // 
            // btn_LogOn
            // 
            this.btn_LogOn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_LogOn.Location = new System.Drawing.Point(210, 298);
            this.btn_LogOn.Name = "btn_LogOn";
            this.btn_LogOn.Size = new System.Drawing.Size(140, 43);
            this.btn_LogOn.TabIndex = 7;
            this.btn_LogOn.Text = "Log On";
            this.btn_LogOn.UseVisualStyleBackColor = true;
            this.btn_LogOn.Click += new System.EventHandler(this.btn_LogOn_Click);
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(361, 298);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(140, 43);
            this.btn_register.TabIndex = 8;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_showPassword
            // 
            this.btn_showPassword.Location = new System.Drawing.Point(396, 200);
            this.btn_showPassword.Name = "btn_showPassword";
            this.btn_showPassword.Size = new System.Drawing.Size(100, 25);
            this.btn_showPassword.TabIndex = 9;
            this.btn_showPassword.Text = "Show password";
            this.btn_showPassword.UseVisualStyleBackColor = true;
            this.btn_showPassword.MouseLeave += new System.EventHandler(this.btn_showPassword_MouseLeave);
            this.btn_showPassword.MouseHover += new System.EventHandler(this.btn_showPassword_MouseHover);
            // 
            // lbl_usernameError
            // 
            this.lbl_usernameError.AutoSize = true;
            this.lbl_usernameError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usernameError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_usernameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_usernameError.Location = new System.Drawing.Point(207, 164);
            this.lbl_usernameError.Name = "lbl_usernameError";
            this.lbl_usernameError.Size = new System.Drawing.Size(43, 19);
            this.lbl_usernameError.TabIndex = 10;
            this.lbl_usernameError.Text = "Error";
            this.lbl_usernameError.Visible = false;
            // 
            // lbl_passwordError
            // 
            this.lbl_passwordError.AutoSize = true;
            this.lbl_passwordError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_passwordError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordError.ForeColor = System.Drawing.Color.Red;
            this.lbl_passwordError.Location = new System.Drawing.Point(208, 226);
            this.lbl_passwordError.Name = "lbl_passwordError";
            this.lbl_passwordError.Size = new System.Drawing.Size(38, 17);
            this.lbl_passwordError.TabIndex = 11;
            this.lbl_passwordError.Text = "Error";
            this.lbl_passwordError.Visible = false;
            // 
            // frm_LogOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.lbl_passwordError);
            this.Controls.Add(this.lbl_usernameError);
            this.Controls.Add(this.btn_showPassword);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_LogOn);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_LogOn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Quiz";
            this.Load += new System.EventHandler(this.frm_LogOn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_LogOn;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_showPassword;
        private System.Windows.Forms.Label lbl_usernameError;
        private System.Windows.Forms.Label lbl_passwordError;
    }
}