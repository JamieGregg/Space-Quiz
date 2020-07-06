using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Drawing.Text;


namespace SpaceQuiz
{
    public partial class frm_Congratulations : Form
    {
        
        PlayerInformation newPlayer;
        PlayerCollection collectPlayer;

        

        public frm_Congratulations()
        {
            InitializeComponent();

        }

        public frm_Congratulations(ref PlayerInformation tempNewPlayer)
        {
            InitializeComponent();
            newPlayer = tempNewPlayer;
            //Trying to load the player data
            try
            {
                Program.LoadObject(ref collectPlayer);
            }
            catch
            {
                MessageBox.Show("Sorry your data could not be loaded");
                
            }
        }
        

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            //Go to main menu
            Form nextForm = new frm_MainMenu(ref newPlayer);
            this.Close();
            nextForm.Show();
        }

        private void btn_highScores_Click(object sender, EventArgs e)
        {
            //Go to high scores
            Form nextForm = new frm_HighScores(ref newPlayer);
            this.Close();
            nextForm.Show();
        }

        private void frm_Congratulations_Load(object sender, EventArgs e)
        {
            // displaying the users score
            lbl_score.Text = Convert.ToString(newPlayer.Score);
            lbl_playerUsername.Text = newPlayer.Username;

            //Testing to see if the user set a new highscore
            if (newPlayer.Score >= collectPlayer.PlayersHighScore(newPlayer.Username))
            {
                collectPlayer.UpdatePlayer(ref newPlayer);
                Program.SaveObject(collectPlayer);
            }

        }
        

        private void lbl_score_Click(object sender, EventArgs e)
        {

        }

        private void lbl_playerUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
