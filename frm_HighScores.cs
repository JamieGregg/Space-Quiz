using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SpaceQuiz
{
    public partial class frm_HighScores : Form
    {
        PlayerInformation newPlayer;
        PlayerCollection collectPlayer;
        string[,] high_scores = new string[3, 2];

        public frm_HighScores()
        {
            InitializeComponent();
            newPlayer = new PlayerInformation();
        }

        public frm_HighScores(ref PlayerInformation tempNewPlayer)
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
                MessageBox.Show("Sorry user data could not be loaded");
                collectPlayer = new PlayerCollection();
            }
        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            //Moving back to the main Menu
            Form nextForm = new frm_MainMenu(ref newPlayer);
            this.Hide();
            nextForm.Show();
        }

        private void frm_HighScores_Load(object sender, EventArgs e)
        {
            //Sorting and displaying the highscore table
            collectPlayer.sortList();
            collectPlayer.displayHighscores(ref listBox1);

        }

       
    }
}
       

    


    

        

