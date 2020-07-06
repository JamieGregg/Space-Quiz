namespace SpaceQuiz
{
    partial class frm_HardLevelThree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HardLevelThree));
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_nextQuestion = new System.Windows.Forms.Button();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.lbl_question = new System.Windows.Forms.Label();
            this.lbl_anwserMessage = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_scoretitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_continue
            // 
            this.btn_continue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.Location = new System.Drawing.Point(243, 305);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(205, 45);
            this.btn_continue.TabIndex = 28;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_nextQuestion
            // 
            this.btn_nextQuestion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nextQuestion.Location = new System.Drawing.Point(232, 305);
            this.btn_nextQuestion.Name = "btn_nextQuestion";
            this.btn_nextQuestion.Size = new System.Drawing.Size(226, 45);
            this.btn_nextQuestion.TabIndex = 27;
            this.btn_nextQuestion.Text = "Finish Quiz";
            this.btn_nextQuestion.UseVisualStyleBackColor = true;
            this.btn_nextQuestion.Visible = false;
            this.btn_nextQuestion.Click += new System.EventHandler(this.btn_nextQuestion_Click);
            // 
            // txt_answer
            // 
            this.txt_answer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_answer.Location = new System.Drawing.Point(168, 173);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(366, 33);
            this.txt_answer.TabIndex = 26;
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.BackColor = System.Drawing.Color.Transparent;
            this.lbl_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_question.Location = new System.Drawing.Point(39, 9);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(593, 110);
            this.lbl_question.TabIndex = 25;
            this.lbl_question.Text = " In what year was pluto \r\nnamed a \"Dwarf planet\" ?\r\n";
            this.lbl_question.Click += new System.EventHandler(this.lbl_question_Click);
            // 
            // lbl_anwserMessage
            // 
            this.lbl_anwserMessage.AutoSize = true;
            this.lbl_anwserMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_anwserMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_anwserMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_anwserMessage.Location = new System.Drawing.Point(55, 210);
            this.lbl_anwserMessage.Name = "lbl_anwserMessage";
            this.lbl_anwserMessage.Size = new System.Drawing.Size(599, 96);
            this.lbl_anwserMessage.TabIndex = 29;
            this.lbl_anwserMessage.Text = "Correct! Pluto, once considered the ninth and most\r\ndistant planet from the sun, " +
    "is now the largest known\r\ndwarf planet in the solar system";
            this.lbl_anwserMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_anwserMessage.Visible = false;
            this.lbl_anwserMessage.Click += new System.EventHandler(this.lbl_anwserMessage_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_score.Location = new System.Drawing.Point(638, 30);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(0, 24);
            this.lbl_score.TabIndex = 31;
            // 
            // lbl_scoretitle
            // 
            this.lbl_scoretitle.AutoSize = true;
            this.lbl_scoretitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_scoretitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoretitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_scoretitle.Location = new System.Drawing.Point(563, 30);
            this.lbl_scoretitle.Name = "lbl_scoretitle";
            this.lbl_scoretitle.Size = new System.Drawing.Size(65, 24);
            this.lbl_scoretitle.TabIndex = 30;
            this.lbl_scoretitle.Text = "Score:";
            // 
            // frm_HardLevelThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_scoretitle);
            this.Controls.Add(this.lbl_anwserMessage);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_nextQuestion);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.lbl_question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HardLevelThree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Quiz";
            this.Load += new System.EventHandler(this.frm_HardLevelThree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Button btn_nextQuestion;
        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Label lbl_anwserMessage;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_scoretitle;
    }
}