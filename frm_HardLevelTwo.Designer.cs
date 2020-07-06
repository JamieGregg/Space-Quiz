namespace SpaceQuiz
{
    partial class frm_HardLevelTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HardLevelTwo));
            this.lbl_question = new System.Windows.Forms.Label();
            this.btn_nextQuestion = new System.Windows.Forms.Button();
            this.lbl_answerTwo = new System.Windows.Forms.Label();
            this.lbl_anwserThree = new System.Windows.Forms.Label();
            this.lbl_anwserOne = new System.Windows.Forms.Label();
            this.lbl_anwserOneb = new System.Windows.Forms.Label();
            this.lbl_answerThreeb = new System.Windows.Forms.Label();
            this.lbl_answerTwob = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_scoretitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.BackColor = System.Drawing.Color.Transparent;
            this.lbl_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_question.Location = new System.Drawing.Point(124, 11);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(465, 110);
            this.lbl_question.TabIndex = 13;
            this.lbl_question.Text = "Match the planet to \r\n  the type of planet";
            this.lbl_question.Click += new System.EventHandler(this.lbl_question_Click);
            // 
            // btn_nextQuestion
            // 
            this.btn_nextQuestion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nextQuestion.Location = new System.Drawing.Point(236, 304);
            this.btn_nextQuestion.Name = "btn_nextQuestion";
            this.btn_nextQuestion.Size = new System.Drawing.Size(226, 45);
            this.btn_nextQuestion.TabIndex = 17;
            this.btn_nextQuestion.Text = "Next Question";
            this.btn_nextQuestion.UseVisualStyleBackColor = true;
            this.btn_nextQuestion.Click += new System.EventHandler(this.btn_nextQuestion_Click);
            // 
            // lbl_answerTwo
            // 
            this.lbl_answerTwo.AutoSize = true;
            this.lbl_answerTwo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_answerTwo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_answerTwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_answerTwo.Location = new System.Drawing.Point(130, 188);
            this.lbl_answerTwo.Name = "lbl_answerTwo";
            this.lbl_answerTwo.Size = new System.Drawing.Size(85, 37);
            this.lbl_answerTwo.TabIndex = 19;
            this.lbl_answerTwo.Text = "Earth";
            this.lbl_answerTwo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_answerTwo_MouseDown);
            // 
            // lbl_anwserThree
            // 
            this.lbl_anwserThree.AutoSize = true;
            this.lbl_anwserThree.BackColor = System.Drawing.Color.Transparent;
            this.lbl_anwserThree.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_anwserThree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_anwserThree.Location = new System.Drawing.Point(130, 248);
            this.lbl_anwserThree.Name = "lbl_anwserThree";
            this.lbl_anwserThree.Size = new System.Drawing.Size(101, 37);
            this.lbl_anwserThree.TabIndex = 20;
            this.lbl_anwserThree.Text = "Saturn";
            this.lbl_anwserThree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_anwserThree_MouseDown);
            // 
            // lbl_anwserOne
            // 
            this.lbl_anwserOne.AutoSize = true;
            this.lbl_anwserOne.BackColor = System.Drawing.Color.Transparent;
            this.lbl_anwserOne.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_anwserOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_anwserOne.Location = new System.Drawing.Point(130, 128);
            this.lbl_anwserOne.Name = "lbl_anwserOne";
            this.lbl_anwserOne.Size = new System.Drawing.Size(107, 37);
            this.lbl_anwserOne.TabIndex = 21;
            this.lbl_anwserOne.Text = "Jupiter";
            this.lbl_anwserOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_anwserOne_MouseDown);
            // 
            // lbl_anwserOneb
            // 
            this.lbl_anwserOneb.AllowDrop = true;
            this.lbl_anwserOneb.AutoSize = true;
            this.lbl_anwserOneb.BackColor = System.Drawing.Color.Transparent;
            this.lbl_anwserOneb.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_anwserOneb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_anwserOneb.Location = new System.Drawing.Point(413, 128);
            this.lbl_anwserOneb.Name = "lbl_anwserOneb";
            this.lbl_anwserOneb.Size = new System.Drawing.Size(178, 37);
            this.lbl_anwserOneb.TabIndex = 24;
            this.lbl_anwserOneb.Text = "Ice and Rock";
            this.lbl_anwserOneb.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbl_anwserOneb_DragDrop);
            this.lbl_anwserOneb.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbl_anwserOneb_DragEnter);
            // 
            // lbl_answerThreeb
            // 
            this.lbl_answerThreeb.AllowDrop = true;
            this.lbl_answerThreeb.AutoSize = true;
            this.lbl_answerThreeb.BackColor = System.Drawing.Color.Transparent;
            this.lbl_answerThreeb.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_answerThreeb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_answerThreeb.Location = new System.Drawing.Point(407, 248);
            this.lbl_answerThreeb.Name = "lbl_answerThreeb";
            this.lbl_answerThreeb.Size = new System.Drawing.Size(274, 37);
            this.lbl_answerThreeb.TabIndex = 23;
            this.lbl_answerThreeb.Text = " Terrestrial (Rockey)";
            this.lbl_answerThreeb.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbl_answerThreeb_DragDrop);
            this.lbl_answerThreeb.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbl_answerThreeb_DragEnter);
            // 
            // lbl_answerTwob
            // 
            this.lbl_answerTwob.AllowDrop = true;
            this.lbl_answerTwob.AutoSize = true;
            this.lbl_answerTwob.BackColor = System.Drawing.Color.Transparent;
            this.lbl_answerTwob.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_answerTwob.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_answerTwob.Location = new System.Drawing.Point(413, 188);
            this.lbl_answerTwob.Name = "lbl_answerTwob";
            this.lbl_answerTwob.Size = new System.Drawing.Size(63, 37);
            this.lbl_answerTwob.TabIndex = 22;
            this.lbl_answerTwob.Text = "Gas";
            this.lbl_answerTwob.Click += new System.EventHandler(this.lbl_answerTwob_Click);
            this.lbl_answerTwob.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbl_answerTwob_DragDrop);
            this.lbl_answerTwob.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbl_answerTwob_DragEnter);
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
            this.lbl_score.TabIndex = 26;
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
            this.lbl_scoretitle.TabIndex = 25;
            this.lbl_scoretitle.Text = "Score:";
            // 
            // frm_HardLevelTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_scoretitle);
            this.Controls.Add(this.lbl_anwserOneb);
            this.Controls.Add(this.lbl_answerThreeb);
            this.Controls.Add(this.lbl_answerTwob);
            this.Controls.Add(this.lbl_anwserOne);
            this.Controls.Add(this.lbl_anwserThree);
            this.Controls.Add(this.lbl_answerTwo);
            this.Controls.Add(this.btn_nextQuestion);
            this.Controls.Add(this.lbl_question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HardLevelTwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Quiz";
            this.Load += new System.EventHandler(this.frm_HardLevelTwo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Button btn_nextQuestion;
        private System.Windows.Forms.Label lbl_answerTwo;
        private System.Windows.Forms.Label lbl_anwserThree;
        private System.Windows.Forms.Label lbl_anwserOne;
        private System.Windows.Forms.Label lbl_anwserOneb;
        private System.Windows.Forms.Label lbl_answerThreeb;
        private System.Windows.Forms.Label lbl_answerTwob;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_scoretitle;
    }
}