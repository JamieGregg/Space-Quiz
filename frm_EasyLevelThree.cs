using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace SpaceQuiz
{
    public partial class frm_EasyLevelThree : Form
    {
        PlayerInformation newPlayer;

        public frm_EasyLevelThree()
        {
            InitializeComponent();
        }

        public frm_EasyLevelThree(ref PlayerInformation tempNewPlayer)
        {
            InitializeComponent();
            newPlayer = tempNewPlayer;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            lbl_anwserMessage.Visible = false;

            if (string.IsNullOrWhiteSpace(this.txt_answer.Text))
            {
                //checking if the textbox is empty
                lbl_anwserMessage.ForeColor = Color.Red;
                lbl_anwserMessage.Location = new Point(153, 212);
                lbl_anwserMessage.Text = "Please enter a value";
                lbl_anwserMessage.Visible = true;
                
            }

            else if (txt_answer.Text == "Neil Armstrong" || txt_answer.Text == "NeilArmstrong" 
                     || txt_answer.Text == "neil Armstrong" || txt_answer.Text == "Neil armstrong"
                     || txt_answer.Text == "neil armstrong" || txt_answer.Text == "Niel Armstrong"
                     || txt_answer.Text == "neil" || txt_answer.Text == "Neil" || txt_answer.Text == "Niel" 
                     || txt_answer.Text == "Armstrong"
                     || txt_answer.Text == "armstrong")
            {
                //checking if the answer is right
                btn_continue.Visible = false;
                btn_nextQuestion.Visible = true;
                txt_answer.Enabled = false;
                lbl_anwserMessage.Visible = true;
                lbl_anwserMessage.ForeColor = Color.Green;
                lbl_anwserMessage.Text = "Correct! Apollo 11 mission carried three astronauts \r\n     towards the moon including Armstrong";
                newPlayer.Score = newPlayer.Score + 5;
                lbl_score.Text = Convert.ToString(newPlayer.Score);
            }
            else
            {
                //checking if the answer is wrong
                lbl_anwserMessage.Visible = true;
                lbl_anwserMessage.ForeColor = Color.Red;
                lbl_anwserMessage.Text = "Incorrect! Apollo 11 mission carried three astronauts \r\n     towards the moon including Armstrong";
                btn_continue.Visible = false;
                txt_answer.Enabled = false;
                btn_nextQuestion.Visible = true;
            }
        }

        private void btn_nextQuestion_Click(object sender, EventArgs e)
        {
            //Moving on to the congratulations screen
            Form nextForm = new frm_Congratulations(ref newPlayer);
            this.Close();
            nextForm.Show();
        }

        private void frm_EasyLevelThree_Load(object sender, EventArgs e)
        {
            //Setting the score in the top right corner
            lbl_score.Text = Convert.ToString(newPlayer.Score);

        }

        private void lbl_question_Click(object sender, EventArgs e)
        {

        }

        private void lbl_anwserMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
