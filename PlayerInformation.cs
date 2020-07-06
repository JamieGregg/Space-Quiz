using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceQuiz
{
    [Serializable]
    public class PlayerInformation: IComparable<PlayerInformation>
    {
        private string username;
        private string password;
        private int score;
        
        public PlayerInformation()
        {
            username = "";
            password = "";
            score = 0;
        }

        public PlayerInformation(string _username, string _password, int _score)
        {
            username = _username;
            password = _password;
            score = _score;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        
        public int CompareTo(PlayerInformation p)
        {
            if (this.Score < p.Score)
                return 1;
            else if (this.Score > p.Score)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return Convert.ToString(score) + "  " + Username; 
        }
    
    }
}
