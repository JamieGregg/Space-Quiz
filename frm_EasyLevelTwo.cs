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
    public partial class frm_EasyLevelTwo : Form
    {
        PlayerInformation newPlayer;

       
        public frm_EasyLevelTwo()
        {
            InitializeComponent();
            newPlayer = new PlayerInformation();

        }

        public frm_EasyLevelTwo(ref PlayerInformation tempNewPlayer)
        {
            InitializeComponent();
            newPlayer = tempNewPlayer;
        }

        private void frm_EasyLevelTwo_Load(object sender, EventArgs e)
        {
            //Setting the score in the top right corner
            lbl_score.Text = Convert.ToString(newPlayer.Score);
        }

        private void btn_nextQuestion_Click(object sender, EventArgs e)
        {
            //Moving on to the next question
            Form nextForm = new frm_EasyLevelThree(ref newPlayer);
            this.Close();
            nextForm.Show();
        }

        private void lbl_anwserOne_Click(object sender, EventArgs e)
        {

        }


        //Drag and drop for answer one
        private void lbl_anwserOne_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl_anwserOne = (Label)sender;
            DoDragDrop(lbl_anwserOne.Text, DragDropEffects.Copy);
        }

        private void txt_answerTwob_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txt_answerTwob_DragDrop(object sender, DragEventArgs e)
        {
            PlayerCollection questions = new PlayerCollection();
            questions.QuestionTwo(sender, e, ref newPlayer, "Earth", "The Moon", "The Sun", ref txt_answerTwob, ref lbl_score, ref lbl_anwserOne, ref lbl_answerTwo, ref lbl_anwserThree);
        }


        //Drag and drop for answer two
        private void lbl_answerTwo_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl_anwserTwo = (Label)sender;
            DoDragDrop(lbl_anwserTwo.Text, DragDropEffects.Copy);
        }

        private void txt_answerThreeb_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txt_answerThreeb_DragDrop(object sender, DragEventArgs e)
        {
            PlayerCollection questions = new PlayerCollection();
            questions.QuestionTwo(sender, e, ref newPlayer, "The Moon", "The Sun", "Earth", ref txt_answerThreeb, ref lbl_score, ref lbl_answerTwo, ref lbl_anwserThree, ref lbl_anwserOne);
        }


        //Drag and drop for anwser three
        private void lbl_anwserThree_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl_anwserThree = (Label)sender;
            DoDragDrop(lbl_anwserThree.Text, DragDropEffects.Copy);
        }

        private void txt_anwserOneb_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txt_anwserOneb_DragDrop(object sender, DragEventArgs e)
        {
            PlayerCollection questions = new PlayerCollection();
            questions.QuestionTwo(sender, e, ref newPlayer, "The Sun", "The Moon", "Earth", ref txt_anwserOneb, ref lbl_score, ref lbl_anwserThree, ref lbl_answerTwo, ref lbl_anwserOne);

            lbl_score.Text = Convert.ToString(newPlayer.Score);
        }

        private void lbl_question_Click(object sender, EventArgs e)
        {

        }
    }
}
