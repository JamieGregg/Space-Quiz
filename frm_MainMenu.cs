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
    public partial class frm_MainMenu : Form
    {
        PlayerInformation newPlayer;
        PlayerCollection collectPlayer;

        public frm_MainMenu()
        {
            InitializeComponent();
            newPlayer = new PlayerInformation();

        }

        public frm_MainMenu(ref PlayerInformation tempNewPlayer)
        {
            InitializeComponent();
            newPlayer = tempNewPlayer;
            Program.LoadObject(ref collectPlayer);
        }

        private void frm_MainMenu_Load(object sender, EventArgs e)
        {
            //Setting the username and highscore in the top left corner
            lbl_user.Text = newPlayer.Username;
            lbl_user.Visible = true;
            lbl_highscore.Text = Convert.ToString(collectPlayer.PlayersHighScore(newPlayer.Username));
            newPlayer.Score = 0;

        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            //move to the next form
            Form nextForm = new frm_HighScores(ref newPlayer);
            this.Close();
            nextForm.Show();
        }

        private void btn_easy_Click(object sender, EventArgs e)
        {
            //move to the next form
            Form nextForm = new frm_EasyLevelOne(ref newPlayer);
            this.Close();
            nextForm.Show();
        }

        private void btn_hard_Click(object sender, EventArgs e)
        {
            //move to the next form
            Form nextForm = new frm_HardLevelOne(ref newPlayer);
            this.Close();
            nextForm.Show();
        }

        private void btn_Medium_Click(object sender, EventArgs e)
        {
            //move to the next form
            Form nextForm = new frm_MediumLevelOne(ref newPlayer);
            this.Close();
            nextForm.Show();
        }

        //Rollover Button Methods
        private void button1_MouseHover(object sender, EventArgs e)
        {
            //rollover button for the easy button 
            //Changing the image 
            btn_easy.Image = Properties.Resources.ButtonEasy;
            lbl_pointsMessage.Visible = true;
            
        }

        private void btn_easy_MouseLeave(object sender, EventArgs e)
        {
            //rollover button for the easy button 
            //Changing the image back to the defualt 
            btn_easy.Image = Properties.Resources.LightEasy;
        }

        private void btn_medium_MouseEnter(object sender, EventArgs e)
        {
            //rollover button for the medium button 
            //Changing the image 
            btn_medium.Image = Properties.Resources.ButtonMedium;
        }

        private void btn_medium_MouseLeave(object sender, EventArgs e)
        {
            //rollover button for the medium button 
            //Changing the image back to the defualt 
            btn_medium.Image = Properties.Resources.LightMedium;
        }

        private void btn_hard_MouseEnter(object sender, EventArgs e)
        {
            //rollover button for the medium button 
            //Changing the image  
            btn_hard.Image = Properties.Resources.ButtonHard;
        }

        private void btn_hard_MouseLeave(object sender, EventArgs e)
        {
            //rollover button for the hard button 
            //Changing the image back to the defualt 
            btn_hard.Image = Properties.Resources.LightHard;
        }

        private void btn_hard_Click_1(object sender, EventArgs e)
        {
            //move to the next form
            Form nextForm = new frm_HardLevelOne(ref newPlayer);
            this.Hide();
            nextForm.Show();
        }

        private void lbl_highscore_Click(object sender, EventArgs e)
        {

        }

        

        

    }
}
