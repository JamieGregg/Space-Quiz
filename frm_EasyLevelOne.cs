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
    public partial class frm_EasyLevelOne : Form
    {
        PlayerInformation newPlayer;

    
        public frm_EasyLevelOne()
        {
            InitializeComponent();
            newPlayer = new PlayerInformation();

        }
        
        public frm_EasyLevelOne(ref PlayerInformation TempNewPlayer)
        {
            InitializeComponent();
            newPlayer = TempNewPlayer;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            //Loading the question one method
            PlayerCollection question = new PlayerCollection();
            question.QuestionOne(ref rdb_anwserOne,ref rdb_anwserTwo,ref rdb_anwserThree,ref lbl_anwserMessage,ref btn_continue,ref btn_nextQuestion,ref lbl_score,ref newPlayer);
        }

        private void btn_nextQuestion_Click(object sender, EventArgs e)
        {
            //Progressing to the next question
            Form nextForm = new frm_EasyLevelTwo(ref newPlayer);
            this.Close();
            nextForm.Show();
        }

        private void lbl_anwserMessage_Click(object sender, EventArgs e)
        {

        }

        private void frm_EasyLevelOne_Load(object sender, EventArgs e)
        {
            //Showing the score in the top right
            lbl_score.Text = Convert.ToString(newPlayer.Score);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_question_Click(object sender, EventArgs e)
        {

        }
    }
}
