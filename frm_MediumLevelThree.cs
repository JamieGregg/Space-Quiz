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
    public partial class frm_MediumLevelThree : Form
    {
        PlayerInformation newPlayer;

        public frm_MediumLevelThree()
        {
            InitializeComponent();
            newPlayer = new PlayerInformation();
        }

        public frm_MediumLevelThree(ref PlayerInformation tempNewPlayer)
        {
            InitializeComponent();
            newPlayer = tempNewPlayer;
        }


        private void btn_continue_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_MediumLevelThree_Load(object sender, EventArgs e)
        {
            //Setting the score as the form loads
            lbl_score.Text = Convert.ToString(newPlayer.Score);
        }

        private void btn_nextQuestion_Click(object sender, EventArgs e)
        {
            //Moving to the next form
            Form nextForm = new frm_Congratulations(ref newPlayer);
            this.Close();
            nextForm.Show();
        }

        private void btn_continue_Click_1(object sender, EventArgs e)
        {
            lbl_anwserMessage.Visible = false;

            //Checking the inputted answer
            if (string.IsNullOrWhiteSpace(this.txt_answer.Text))
            {
                lbl_anwserMessage.ForeColor = Color.Red;
                lbl_anwserMessage.Location = new Point(162, 222);
                lbl_anwserMessage.Text = "Please enter a value";
                lbl_anwserMessage.Visible = true;
            }

            else if (txt_answer.Text == "8" || txt_answer.Text == "eight" ||
                     txt_answer.Text == "Eight")
            {
                newPlayer.Score = newPlayer.Score + 10;
                txt_answer.ForeColor = Color.Green;
                lbl_anwserMessage.ForeColor = Color.Green;
                lbl_anwserMessage.Text = "Correct! There are also 4 dwarf planets, 181 moons \r\n                       and 552,894 astroids";
                lbl_anwserMessage.Visible = true;
                txt_answer.Enabled = false;
            }

            else
            {
                lbl_anwserMessage.ForeColor = Color.Red;
                lbl_anwserMessage.Text = "Incorrect! There are 8 planets. There are also 4 dwarf\r\n              planets 181 moons and 552,894 astroids";
                lbl_anwserMessage.Visible = true;
                txt_answer.Enabled = false;
                newPlayer.Score = newPlayer.Score - 5;
            }
            //Updating the score
            lbl_score.Text = Convert.ToString(newPlayer.Score);
            btn_continue.Visible = false;
        }

        private void lbl_question_Click(object sender, EventArgs e)
        {

        }
    }
}
