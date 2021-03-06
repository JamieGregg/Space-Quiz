﻿namespace SpaceQuiz
{
    partial class frm_MediumLevelOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MediumLevelOne));
            this.btn_continue = new System.Windows.Forms.Button();
            this.lbl_question = new System.Windows.Forms.Label();
            this.rdb_anwserThree = new System.Windows.Forms.RadioButton();
            this.rdb_anwserTwo = new System.Windows.Forms.RadioButton();
            this.rdb_anwserOne = new System.Windows.Forms.RadioButton();
            this.btn_nextQuestion = new System.Windows.Forms.Button();
            this.lbl_anwserMessage = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_scoretitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_continue
            // 
            this.btn_continue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.Location = new System.Drawing.Point(220, 304);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(205, 45);
            this.btn_continue.TabIndex = 12;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.BackColor = System.Drawing.Color.Transparent;
            this.lbl_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_question.Location = new System.Drawing.Point(34, 4);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(624, 110);
            this.lbl_question.TabIndex = 11;
            this.lbl_question.Text = "      What is the biggest\r\nplanet in our solar system?";
            // 
            // rdb_anwserThree
            // 
            this.rdb_anwserThree.AutoSize = true;
            this.rdb_anwserThree.BackColor = System.Drawing.Color.Transparent;
            this.rdb_anwserThree.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_anwserThree.ForeColor = System.Drawing.SystemColors.Control;
            this.rdb_anwserThree.Location = new System.Drawing.Point(266, 226);
            this.rdb_anwserThree.Name = "rdb_anwserThree";
            this.rdb_anwserThree.Size = new System.Drawing.Size(108, 36);
            this.rdb_anwserThree.TabIndex = 10;
            this.rdb_anwserThree.TabStop = true;
            this.rdb_anwserThree.Text = "Jupiter";
            this.rdb_anwserThree.UseVisualStyleBackColor = false;
            // 
            // rdb_anwserTwo
            // 
            this.rdb_anwserTwo.AutoSize = true;
            this.rdb_anwserTwo.BackColor = System.Drawing.Color.Transparent;
            this.rdb_anwserTwo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_anwserTwo.ForeColor = System.Drawing.SystemColors.Control;
            this.rdb_anwserTwo.Location = new System.Drawing.Point(266, 184);
            this.rdb_anwserTwo.Name = "rdb_anwserTwo";
            this.rdb_anwserTwo.Size = new System.Drawing.Size(87, 36);
            this.rdb_anwserTwo.TabIndex = 9;
            this.rdb_anwserTwo.TabStop = true;
            this.rdb_anwserTwo.Text = "Mars";
            this.rdb_anwserTwo.UseVisualStyleBackColor = false;
            // 
            // rdb_anwserOne
            // 
            this.rdb_anwserOne.AutoSize = true;
            this.rdb_anwserOne.BackColor = System.Drawing.Color.Transparent;
            this.rdb_anwserOne.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_anwserOne.ForeColor = System.Drawing.SystemColors.Control;
            this.rdb_anwserOne.Location = new System.Drawing.Point(266, 142);
            this.rdb_anwserOne.Name = "rdb_anwserOne";
            this.rdb_anwserOne.Size = new System.Drawing.Size(110, 36);
            this.rdb_anwserOne.TabIndex = 8;
            this.rdb_anwserOne.TabStop = true;
            this.rdb_anwserOne.Text = "Uranus";
            this.rdb_anwserOne.UseVisualStyleBackColor = false;
            // 
            // btn_nextQuestion
            // 
            this.btn_nextQuestion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nextQuestion.Location = new System.Drawing.Point(220, 304);
            this.btn_nextQuestion.Name = "btn_nextQuestion";
            this.btn_nextQuestion.Size = new System.Drawing.Size(226, 45);
            this.btn_nextQuestion.TabIndex = 13;
            this.btn_nextQuestion.Text = "Next Question";
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
            this.lbl_anwserMessage.Location = new System.Drawing.Point(62, 265);
            this.lbl_anwserMessage.Name = "lbl_anwserMessage";
            this.lbl_anwserMessage.Size = new System.Drawing.Size(569, 32);
            this.lbl_anwserMessage.TabIndex = 15;
            this.lbl_anwserMessage.Text = "Correct! Over 1300 Earths could fit inside of Jupiter";
            this.lbl_anwserMessage.Visible = false;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_score.Location = new System.Drawing.Point(632, 21);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(0, 24);
            this.lbl_score.TabIndex = 17;
            // 
            // lbl_scoretitle
            // 
            this.lbl_scoretitle.AutoSize = true;
            this.lbl_scoretitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_scoretitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoretitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_scoretitle.Location = new System.Drawing.Point(557, 21);
            this.lbl_scoretitle.Name = "lbl_scoretitle";
            this.lbl_scoretitle.Size = new System.Drawing.Size(65, 24);
            this.lbl_scoretitle.TabIndex = 16;
            this.lbl_scoretitle.Text = "Score:";
            // 
            // frm_MediumLevelOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_scoretitle);
            this.Controls.Add(this.lbl_anwserMessage);
            this.Controls.Add(this.btn_nextQuestion);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.rdb_anwserThree);
            this.Controls.Add(this.rdb_anwserTwo);
            this.Controls.Add(this.rdb_anwserOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MediumLevelOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Quiz";
            this.Load += new System.EventHandler(this.frm_MediumLevelOne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.RadioButton rdb_anwserThree;
        private System.Windows.Forms.RadioButton rdb_anwserTwo;
        private System.Windows.Forms.RadioButton rdb_anwserOne;
        private System.Windows.Forms.Button btn_nextQuestion;
        private System.Windows.Forms.Label lbl_anwserMessage;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_scoretitle;
    }
}