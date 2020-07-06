namespace SpaceQuiz
{
    partial class frm_EasyLevelThree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EasyLevelThree));
            this.lbl_question = new System.Windows.Forms.Label();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_nextQuestion = new System.Windows.Forms.Button();
            this.lbl_anwserMessage = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_scoretitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.BackColor = System.Drawing.Color.Transparent;
            this.lbl_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_question.Location = new System.Drawing.Point(66, 57);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(553, 110);
            this.lbl_question.TabIndex = 4;
            this.lbl_question.Text = "What is the name of the\r\n first man on the moon?";
            this.lbl_question.Click += new System.EventHandler(this.lbl_question_Click);
            // 
            // txt_answer
            // 
            this.txt_answer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_answer.Location = new System.Drawing.Point(159, 176);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(338, 33);
            this.txt_answer.TabIndex = 5;
            // 
            // btn_continue
            // 
            this.btn_continue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.Location = new System.Drawing.Point(234, 295);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(205, 45);
            this.btn_continue.TabIndex = 20;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_nextQuestion
            // 
            this.btn_nextQuestion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nextQuestion.Location = new System.Drawing.Point(223, 295);
            this.btn_nextQuestion.Name = "btn_nextQuestion";
            this.btn_nextQuestion.Size = new System.Drawing.Size(226, 45);
            this.btn_nextQuestion.TabIndex = 19;
            this.btn_nextQuestion.Text = "Finish Quiz";
            this.btn_nextQuestion.UseVisualStyleBackColor = true;
            this.btn_nextQuestion.Visible = false;
            this.btn_nextQuestion.Click += new System.EventHandler(this.btn_nextQuestion_Click);
            // 
            // lbl_anwserMessage
            // 
            this.lbl_anwserMessage.AutoSize = true;
            this.lbl_anwserMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_anwserMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_anwserMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_anwserMessage.Location = new System.Drawing.Point(56, 216);
            this.lbl_anwserMessage.Name = "lbl_anwserMessage";
            this.lbl_anwserMessage.Size = new System.Drawing.Size(563, 64);
            this.lbl_anwserMessage.TabIndex = 26;
            this.lbl_anwserMessage.Text = "Correct! Apollo 11 mission carried three astronauts\r\n         toward the moon inc" +
    "luding Armstrong ";
            this.lbl_anwserMessage.Visible = false;
            this.lbl_anwserMessage.Click += new System.EventHandler(this.lbl_anwserMessage_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_score.Location = new System.Drawing.Point(643, 33);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(0, 24);
            this.lbl_score.TabIndex = 28;
            // 
            // lbl_scoretitle
            // 
            this.lbl_scoretitle.AutoSize = true;
            this.lbl_scoretitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_scoretitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoretitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_scoretitle.Location = new System.Drawing.Point(110, -70);
            this.lbl_scoretitle.Name = "lbl_scoretitle";
            this.lbl_scoretitle.Size = new System.Drawing.Size(65, 24);
            this.lbl_scoretitle.TabIndex = 27;
            this.lbl_scoretitle.Text = "Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(644, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(572, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Score:";
            // 
            // frm_EasyLevelThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_scoretitle);
            this.Controls.Add(this.lbl_anwserMessage);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_nextQuestion);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.lbl_question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EasyLevelThree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Quiz";
            this.Load += new System.EventHandler(this.frm_EasyLevelThree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Button btn_nextQuestion;
        private System.Windows.Forms.Label lbl_anwserMessage;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_scoretitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}