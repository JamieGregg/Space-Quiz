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
    public partial class frm_MediumLevelOne : Form
    {
        PlayerInformation newPlayer;

        public frm_MediumLevelOne()
        {
            InitializeComponent();
            newPlayer = new PlayerInformation();
        }
        
        public frm_MediumLevelOne(ref PlayerInformation tempNewPlayer)
        {
            InitializeComponent();
            newPlayer = tempNewPlayer;
        }

        private void btn_nextQuestion_Click(object sender, EventArgs e)
        {
            //Progressing to the next question
            Form nextForm = new frm_MediumLevelTwo(ref newPlayer);
            this.Close();
            nextForm.Show();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            //Loading the question one method
            PlayerCollection questions = new PlayerCollection();
            questions.QuestionOne(ref rdb_anwserThree, ref rdb_anwserTwo, ref rdb_anwserOne, ref lbl_anwserMessage, ref btn_continue, ref btn_nextQuestion, ref lbl_score, ref newPlayer);
        }
        
        private void frm_MediumLevelOne_Load(object sender, EventArgs e)
        {
            //Displaying the score
            lbl_score.Text = Convert.ToString(newPlayer.Score);
        }
    }
}