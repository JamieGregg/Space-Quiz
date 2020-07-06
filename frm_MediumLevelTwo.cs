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
    public partial class frm_MediumLevelTwo : Form
    {
        PlayerInformation newPlayer;

        public frm_MediumLevelTwo()
        {
            InitializeComponent();
            newPlayer = new PlayerInformation();
        }

        public frm_MediumLevelTwo(ref PlayerInformation tempNewPlayer)
        {
            InitializeComponent();
            newPlayer = tempNewPlayer;
        }

        private void frm_MediumLevelTwo_Load(object sender, EventArgs e)
        {
            //Setting the score as the form loads
            lbl_score.Text = Convert.ToString(newPlayer.Score);
        }

        private void btn_nextQuestion_Click(object sender, EventArgs e)
        {
            //Progressing to the next question
            Form nextForm = new frm_MediumLevelThree(ref newPlayer);
            this.Close();
            nextForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //Drag and drop for question one
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
            questions.QuestionTwo(sender, e,ref  newPlayer, "Mars", "Mercury", "Jupiter",ref txt_answerTwob, ref lbl_score, ref lbl_anwserOne, ref lbl_answerTwo, ref lbl_anwserThree);
          
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
            questions.QuestionTwo(sender, e,ref  newPlayer, "Mercury", "Mars", "Jupiter", ref txt_answerThreeb, ref lbl_score, ref lbl_answerTwo, ref lbl_anwserOne, ref lbl_anwserThree);
        }


        //Drag and drop for answer three
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
            questions.QuestionTwo(sender, e,ref  newPlayer, "Jupiter", "Mercury", "Mars", ref txt_anwserOneb, ref lbl_score, ref lbl_anwserThree, ref lbl_answerTwo, ref lbl_anwserOne);
        }
    }
}
