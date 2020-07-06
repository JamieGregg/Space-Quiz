using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceQuiz
{
    public partial class frm_HardLevelThree : Form
    {
        PlayerInformation newPlayer;

        public frm_HardLevelThree()
        {
            InitializeComponent();
            newPlayer = new PlayerInformation();
        }
        
        public frm_HardLevelThree(ref PlayerInformation tempNewPlayer)
        {
            InitializeComponent();
            newPlayer = tempNewPlayer;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            lbl_anwserMessage.Visible = false;

            //Testing if textbox is empty 
            if (string.IsNullOrWhiteSpace(this.txt_answer.Text))
            {
                lbl_anwserMessage.ForeColor = Color.Red;
                lbl_anwserMessage.Location = new Point(162, 222);
                lbl_anwserMessage.Text = "Please enter a value";
                lbl_anwserMessage.Visible = true;
            }
            //Testing if the answer is correct
            else if(txt_answer.Text == "2006")
            {
                txt_answer.ForeColor = Color.Green;
                lbl_anwserMessage.ForeColor = Color.Green;
                lbl_anwserMessage.Visible = true;
                btn_continue.Visible = false;
                btn_nextQuestion.Visible = true;
                lbl_anwserMessage.Visible = true;
                lbl_anwserMessage.Text = "Correct! Pluto, once considered the ninth and most \r\n distant planet from the sun, is now the largest known \r\n dwarf planet in the solar system";
                newPlayer.Score = newPlayer.Score + 20;
            }
            //If answer is incorrect
            else
            {
                lbl_anwserMessage.Text = "Incorrect! Pluto, once considered the ninth and most \r\n distant planet from the sun, is now the largest known \r\n dwarf planet in the solar system";
                lbl_anwserMessage.ForeColor = Color.Red;
                lbl_anwserMessage.Visible = true;
                btn_continue.Visible = false;
                btn_nextQuestion.Visible = true;
                newPlayer.Score = newPlayer.Score - 10;
            }
            lbl_score.Text = Convert.ToString(newPlayer.Score);
        }

        private void btn_nextQuestion_Click(object sender, EventArgs e)
        {
            //Moving to the next from
            Form nextForm = new frm_Congratulations(ref newPlayer);
            this.Close();
            nextForm.Show();
        }

        private void frm_HardLevelThree_Load(object sender, EventArgs e)
        {
            //Displaying the score 
            lbl_score.Text = Convert.ToString(newPlayer.Score);
        }

        private void lbl_anwserMessage_Click(object sender, EventArgs e)
        {

        }

        private void lbl_question_Click(object sender, EventArgs e)
        {

        }
    }
}
