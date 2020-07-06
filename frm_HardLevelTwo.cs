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
    public partial class frm_HardLevelTwo : Form
    {
        PlayerInformation newPlayer;

        public frm_HardLevelTwo()
        {
            InitializeComponent();
            newPlayer = new PlayerInformation();

        }
        public frm_HardLevelTwo(ref PlayerInformation tempNewPlayer)
        {
            newPlayer = tempNewPlayer;
            InitializeComponent();
        }


        private void lbl_answerTwob_Click(object sender, EventArgs e)
        {

        }


        private void frm_HardLevelTwo_Load(object sender, EventArgs e)
        {
            //Setting the score
            lbl_score.Text = Convert.ToString(newPlayer.Score);
        }


        // Anwser one Drag Drop methods
        private void lbl_anwserOne_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl_anwserOne = (Label)sender;
            DoDragDrop(lbl_anwserOne.Text, DragDropEffects.Copy);
        }

        private void lbl_answerTwob_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lbl_answerTwob_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(typeof(string)).ToString())
            {
                case "Jupiter":
                    lbl_answerTwob.ForeColor = Color.Green;
                    lbl_answerTwob.Text = "Correct!";
                    newPlayer.Score = newPlayer.Score + 20;
                    lbl_anwserOne.Visible = false;
                    break;
                case "Earth":
                    lbl_answerTwob.ForeColor = Color.Red;
                    lbl_answerTwob.Text = "Incorrect!";
                    lbl_answerTwo.Visible = false;
                    newPlayer.Score = newPlayer.Score - 5;
                    break;
                case "Saturn":
                    lbl_answerTwob.ForeColor = Color.Red;
                    lbl_answerTwob.Text = "Incorrect!";
                    lbl_answerTwo.Visible = false;
                    newPlayer.Score = newPlayer.Score - 5;
                    break;
            }
        }


        // Anwser 2 Drag Drop Methods
        private void lbl_answerTwo_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl_anwserTwo = (Label)sender;
            DoDragDrop(lbl_anwserTwo.Text, DragDropEffects.Copy);
        }

        private void lbl_answerThreeb_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lbl_answerThreeb_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(typeof(string)).ToString())
            {
                case "Earth":
                    lbl_answerThreeb.ForeColor = Color.Green;
                    lbl_answerThreeb.Text = "Correct!";
                    newPlayer.Score = newPlayer.Score + 20;
                    lbl_answerTwo.Visible = false;
                    break;
                case "Jupiter":
                    lbl_answerThreeb.ForeColor = Color.Red;
                    lbl_answerThreeb.Text = "Incorrect!";
                    lbl_anwserOne.Visible = false;
                    newPlayer.Score = newPlayer.Score - 5;
                    break;
                case "Saturn":
                    lbl_answerThreeb.ForeColor = Color.Red;
                    lbl_answerThreeb.Text = "Incorrect!";
                    lbl_anwserThree.Visible = false;
                    newPlayer.Score = newPlayer.Score - 5;
                    break;
            }

            lbl_score.Text = Convert.ToString(newPlayer.Score);
        }


        //Anwser three Drag Drop Methods
        private void lbl_anwserThree_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl_anwserThree = (Label)sender;
            DoDragDrop(lbl_anwserThree.Text, DragDropEffects.Copy);
        }

        private void lbl_anwserOneb_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lbl_anwserOneb_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(typeof(string)).ToString())
            {
                case "Saturn":
                    lbl_anwserOneb.ForeColor = Color.Green;
                    lbl_anwserOneb.Text = "Correct!";
                    newPlayer.Score = newPlayer.Score + 20;
                    lbl_anwserThree.Visible = false;
                    break;
                case "Jupiter":
                    lbl_anwserOneb.ForeColor = Color.Red;
                    lbl_anwserOneb.Text = "Incorrect!";
                    newPlayer.Score = newPlayer.Score - 5;
                    lbl_anwserOne.Visible = false;
                    break;
                case "Earth":
                    lbl_anwserOneb.ForeColor = Color.Red;
                    lbl_anwserOneb.Text = "Incorrect!";
                    newPlayer.Score = newPlayer.Score - 5;
                    lbl_answerTwo.Visible = false;
                    break;
            }

            lbl_score.Text = Convert.ToString(newPlayer.Score);
        }

            private void btn_nextQuestion_Click(object sender, EventArgs e)

            {
                //Go to Question 3
                Form nextForm = new frm_HardLevelThree(ref newPlayer);
                this.Close();
                nextForm.Show();
            }

            private void lbl_question_Click(object sender, EventArgs e)
            {

            }
    }
}
        


    




