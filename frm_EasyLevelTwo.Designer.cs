namespace SpaceQuiz
{
    partial class frm_EasyLevelTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EasyLevelTwo));
            this.lbl_question = new System.Windows.Forms.Label();
            this.btn_nextQuestion = new System.Windows.Forms.Button();
            this.lbl_anwserOne = new System.Windows.Forms.Label();
            this.lbl_anwserThree = new System.Windows.Forms.Label();
            this.lbl_answerTwo = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_scoretitle = new System.Windows.Forms.Label();
            this.txt_answerThreeb = new System.Windows.Forms.TextBox();
            this.txt_answerTwob = new System.Windows.Forms.TextBox();
            this.txt_anwserOneb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.BackColor = System.Drawing.Color.Transparent;
            this.lbl_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_question.Location = new System.Drawing.Point(21, 11);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(628, 220);
            this.lbl_question.TabIndex = 14;
            this.lbl_question.Text = "     Drag the name of the\r\n planets in the order of size\r\n\r\n  ";
            this.lbl_question.Click += new System.EventHandler(this.lbl_question_Click);
            // 
            // btn_nextQuestion
            // 
            this.btn_nextQuestion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nextQuestion.Location = new System.Drawing.Point(220, 304);
            this.btn_nextQuestion.Name = "btn_nextQuestion";
            this.btn_nextQuestion.Size = new System.Drawing.Size(226, 45);
            this.btn_nextQuestion.TabIndex = 15;
            this.btn_nextQuestion.Text = "Next Question";
            this.btn_nextQuestion.UseVisualStyleBackColor = true;
            this.btn_nextQuestion.Click += new System.EventHandler(this.btn_nextQuestion_Click);
            // 
            // lbl_anwserOne
            // 
            this.lbl_anwserOne.AutoSize = true;
            this.lbl_anwserOne.BackColor = System.Drawing.Color.Transparent;
            this.lbl_anwserOne.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_anwserOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_anwserOne.Location = new System.Drawing.Point(107, 137);
            this.lbl_anwserOne.Name = "lbl_anwserOne";
            this.lbl_anwserOne.Size = new System.Drawing.Size(85, 37);
            this.lbl_anwserOne.TabIndex = 27;
            this.lbl_anwserOne.Text = "Earth";
            this.lbl_anwserOne.Click += new System.EventHandler(this.lbl_anwserOne_Click);
            this.lbl_anwserOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_anwserOne_MouseDown);
            // 
            // lbl_anwserThree
            // 
            this.lbl_anwserThree.AutoSize = true;
            this.lbl_anwserThree.BackColor = System.Drawing.Color.Transparent;
            this.lbl_anwserThree.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_anwserThree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_anwserThree.Location = new System.Drawing.Point(107, 257);
            this.lbl_anwserThree.Name = "lbl_anwserThree";
            this.lbl_anwserThree.Size = new System.Drawing.Size(118, 37);
            this.lbl_anwserThree.TabIndex = 26;
            this.lbl_anwserThree.Text = "The Sun";
            this.lbl_anwserThree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_anwserThree_MouseDown);
            // 
            // lbl_answerTwo
            // 
            this.lbl_answerTwo.AutoSize = true;
            this.lbl_answerTwo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_answerTwo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_answerTwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_answerTwo.Location = new System.Drawing.Point(107, 197);
            this.lbl_answerTwo.Name = "lbl_answerTwo";
            this.lbl_answerTwo.Size = new System.Drawing.Size(147, 37);
            this.lbl_answerTwo.TabIndex = 25;
            this.lbl_answerTwo.Text = "The Moon";
            this.lbl_answerTwo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_answerTwo_MouseDown);
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
            this.lbl_score.TabIndex = 29;
            // 
            // lbl_scoretitle
            // 
            this.lbl_scoretitle.AutoSize = true;
            this.lbl_scoretitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_scoretitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoretitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_scoretitle.Location = new System.Drawing.Point(572, 33);
            this.lbl_scoretitle.Name = "lbl_scoretitle";
            this.lbl_scoretitle.Size = new System.Drawing.Size(65, 24);
            this.lbl_scoretitle.TabIndex = 28;
            this.lbl_scoretitle.Text = "Score:";
            // 
            // txt_answerThreeb
            // 
            this.txt_answerThreeb.AllowDrop = true;
            this.txt_answerThreeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_answerThreeb.Location = new System.Drawing.Point(471, 268);
            this.txt_answerThreeb.Name = "txt_answerThreeb";
            this.txt_answerThreeb.ReadOnly = true;
            this.txt_answerThreeb.Size = new System.Drawing.Size(130, 27);
            this.txt_answerThreeb.TabIndex = 35;
            this.txt_answerThreeb.Tag = "";
            this.txt_answerThreeb.Text = "Smallest";
            this.txt_answerThreeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_answerThreeb.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_answerThreeb_DragDrop);
            this.txt_answerThreeb.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_answerThreeb_DragEnter);
            // 
            // txt_answerTwob
            // 
            this.txt_answerTwob.AllowDrop = true;
            this.txt_answerTwob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_answerTwob.Location = new System.Drawing.Point(471, 208);
            this.txt_answerTwob.Name = "txt_answerTwob";
            this.txt_answerTwob.ReadOnly = true;
            this.txt_answerTwob.Size = new System.Drawing.Size(130, 27);
            this.txt_answerTwob.TabIndex = 34;
            this.txt_answerTwob.Text = "Middle";
            this.txt_answerTwob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_answerTwob.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_answerTwob_DragDrop);
            this.txt_answerTwob.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_answerTwob_DragEnter);
            // 
            // txt_anwserOneb
            // 
            this.txt_anwserOneb.AllowDrop = true;
            this.txt_anwserOneb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_anwserOneb.Location = new System.Drawing.Point(471, 148);
            this.txt_anwserOneb.Name = "txt_anwserOneb";
            this.txt_anwserOneb.ReadOnly = true;
            this.txt_anwserOneb.Size = new System.Drawing.Size(130, 27);
            this.txt_anwserOneb.TabIndex = 33;
            this.txt_anwserOneb.Text = "Biggest";
            this.txt_anwserOneb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_anwserOneb.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_anwserOneb_DragDrop);
            this.txt_anwserOneb.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_anwserOneb_DragEnter);
            // 
            // frm_EasyLevelTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.txt_answerThreeb);
            this.Controls.Add(this.txt_answerTwob);
            this.Controls.Add(this.txt_anwserOneb);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_scoretitle);
            this.Controls.Add(this.lbl_anwserOne);
            this.Controls.Add(this.lbl_anwserThree);
            this.Controls.Add(this.lbl_answerTwo);
            this.Controls.Add(this.btn_nextQuestion);
            this.Controls.Add(this.lbl_question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EasyLevelTwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Quiz";
            this.Load += new System.EventHandler(this.frm_EasyLevelTwo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Button btn_nextQuestion;
        private System.Windows.Forms.Label lbl_anwserOne;
        private System.Windows.Forms.Label lbl_anwserThree;
        private System.Windows.Forms.Label lbl_answerTwo;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_scoretitle;
        private System.Windows.Forms.TextBox txt_answerThreeb;
        private System.Windows.Forms.TextBox txt_answerTwob;
        private System.Windows.Forms.TextBox txt_anwserOneb;
    }
}