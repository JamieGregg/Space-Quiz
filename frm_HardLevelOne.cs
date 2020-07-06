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
    public partial class frm_HardLevelOne : Form
    {
        PlayerInformation newPlayer;

        public frm_HardLevelOne()
        {
            InitializeComponent();
            newPlayer = new PlayerInformation();

        }

        public frm_HardLevelOne(ref PlayerInformation tempNewPlayer)
        {
            InitializeComponent();
            newPlayer = tempNewPlayer;
        }

        private void frm_HardLevelOne_Load(object sender, EventArgs e)
        {
            //Displaying the score
            lbl_score.Text = Convert.ToString(newPlayer.Score);

        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            //Loading the Question one method
            PlayerCollection questions = new PlayerCollection();
            questions.QuestionOne(ref rdb_anwserTwo,ref rdb_anwserOne,ref rdb_anwserThree,ref lbl_anwserMessage,ref btn_continue,ref btn_nextQuestion,ref lbl_score,ref newPlayer);
        }

        private void btn_nextQuestion_Click(object sender, EventArgs e)
        {
            //Go to Question 3
            Form nextForm = new frm_HardLevelTwo(ref newPlayer);
            this.Close();
            nextForm.Show();

        }
    }
}
        
    

