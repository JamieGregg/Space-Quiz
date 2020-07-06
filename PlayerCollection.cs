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
    [Serializable]
    public class PlayerCollection
    {
        private List<PlayerInformation> playerlist = new List<PlayerInformation>();
        private int playerCount;

        public PlayerCollection()
        {
            playerCount = 0;
        }

        public int PlayerCount
        {
            get { return playerCount; }
        }

        public void AddPlayer(ref PlayerInformation newplayer)
        {
            //Adds a player to the list
            playerlist.Add(newplayer);
        }

        public int FindIndex(string username)
        {
            //Returns players index number 
            PlayerInformation p = null;
            bool found = false;
            int i = playerCount - 1;

            while (i >= 0 && found == false)
            {
                p = playerlist[i];

                if (p.Username == username)
                {
                    found = true;
                }
                else
                {
                    i = i - 1;
                }
            }
            return i;
        }

        public void RemovePlayer(int playerIndex)
        {
            //Removes a player from the list
            if (playerIndex >= 0 && playerIndex < playerCount)
            {
                for (int i = playerIndex + 1; i < playerCount; i++)
                {
                    playerlist[i - 1] = playerlist[i];
                }
                playerlist[playerCount - 1] = null;
                playerCount--;
                MessageBox.Show("The player has been removed");
            }
            else
            {
                MessageBox.Show("This player has been removed");
            }
        }

        public PlayerInformation GetPlayer(string username)
        {
            //Finding a player based on their username
            PlayerInformation thisPlayer;
            thisPlayer = playerlist.Find(player => player.Username == username);
            return thisPlayer;
        }

        public int PlayersHighScore(string username)
        {
            //Finding a users highscore based on their username
            PlayerInformation thisPlayer;
            thisPlayer = playerlist.Find(player => player.Username == username);
            return thisPlayer.Score;

        }

        public void UpdatePlayer(ref PlayerInformation thisPlayer)
        {
            //Updating the player information
            string user_name = thisPlayer.Username;
            int index = playerlist.FindIndex(player => player.Username == user_name);
            playerlist[index] = thisPlayer;
        }

        public void sortList()
        {
            // Array.Sort(playerlist);
            playerlist.Sort();
        }

        public void displayHighscores(ref ListBox thisList)
        {
            //Displaying the user data in the listbox
            foreach (PlayerInformation c in playerlist)
            {
                if (c.Score > 0)
                    thisList.Items.Add(c);
            }
        }



        public void QuestionOne(ref RadioButton one, ref RadioButton two, ref RadioButton three, ref Label answerMessage, ref Button continuee, ref Button nextQuestion, ref Label score, ref PlayerInformation newPlayer)
        {
            //Decides if the users answer is correct
            if (one.Checked)
            {
                //Shows the user they are correct
                one.ForeColor = Color.Green;
                answerMessage.Visible = true;
                continuee.Visible = false;
                nextQuestion.Visible = true;
                newPlayer.Score = newPlayer.Score + 5;
                score.Text = Convert.ToString(newPlayer.Score);
            }
            else if (two.Checked || three.Checked)
            {
                //Shows the user they are incorrect
                two.ForeColor = Color.Red;
                three.ForeColor = Color.Red;
                answerMessage.Location = new Point(97, 264);
                answerMessage.ForeColor = Color.Red;
                answerMessage.Text = "Unlucky! You lose 2 points from your score";
                newPlayer.Score = newPlayer.Score - 2;
                score.Text = Convert.ToString(newPlayer.Score);
                answerMessage.Visible = true;
                continuee.Visible = false;
                nextQuestion.Visible = true;
            }
            else
            {
                //Shows the user no anwser was enetered
                answerMessage.ForeColor = Color.Red;
                answerMessage.Text = "Please enter an Anwser";
                answerMessage.Location = new Point(190, 269);
                answerMessage.Visible = true;
            }
        }


        public void QuestionTwo(object sender, DragEventArgs a, ref PlayerInformation newPlayer, string answerCorrect, string answer2, string answer3, ref TextBox target, ref Label score, ref Label answerRight, ref Label answerTwo, ref Label answerThree)
        {
            if (answerCorrect == a.Data.GetData(typeof(string)).ToString())
            {
                target.BackColor = Color.Green;
                target.Text = "Correct!";
                newPlayer.Score = newPlayer.Score + 20;
                answerRight.Visible = false;
            }
            else if (answer2 == a.Data.GetData(typeof(string)).ToString())
            {
                target.BackColor = Color.Red;
                target.Text = "Incorrect!";
                newPlayer.Score = newPlayer.Score - 5;
                answerTwo.Visible = false;

            }
            else if (answer3 == a.Data.GetData(typeof(string)).ToString())
            {
                target.BackColor = Color.Red;
                target.Text = "Incorrect!";
                newPlayer.Score = newPlayer.Score - 5;
                answerThree.Visible = false;
            }

            score.Text = Convert.ToString(newPlayer.Score);
        }

        public void sortPlayers()
        {
            //Sorting players
            playerlist.Sort((x, y) => x.Score);
        }
    }
}

  

          

    

