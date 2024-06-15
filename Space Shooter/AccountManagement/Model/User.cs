using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.AccountManagement.Model
{
    public class User
    {
        public int id;
        public string name;
        public string password;
        public string email;
        public string avaPath;
        public Dictionary<string, int> highestScore;
        public Dictionary<string, int> playTime;

        public User()
        {
            highestScore = new Dictionary<string, int>()
            {
                {"easy", 0},
                {"normal", 0},
                {"hard", 0}
            };

            playTime = new Dictionary<string, int>()
            {
                {"easy", -1 },
                {"normal", -1 },
                {"hard", -1}
            };

            name = "Unknown";
            password = "Unknown";
            email = "Unknown";
            avaPath = Repository.FilePathManager.GetFilePath("images") + "defaultAvatar.png";
        }

        public User(string fullName, string password, string email, string pathToAvatar, Dictionary<string, int> highestScore, Dictionary<string, int> playTime)
        {
            name = fullName;
            this.password = password;
            this.email = email;
            avaPath = pathToAvatar;
            this.highestScore = highestScore;
            this.playTime = playTime;

            if (this.highestScore == null)
            {
                this.highestScore = new Dictionary<string, int>()
                {
                    {"easy", 0},
                    {"normal", 0},
                    {"hard", 0}
                };
            }

            if (this.playTime == null)
            {
                this.playTime = new Dictionary<string, int>()
                {
                    {"easy", -1 },
                    {"normal", -1 },
                    {"hard", -1}
                };
            }
        }

        public void SetHighestScore(string difficulty, int score)
        {
            if (highestScore.ContainsKey(difficulty))
            {
                highestScore[difficulty] = score;
            }
        }

        public void SetPlayTime(string difficulty, int time)
        {
            if (playTime.ContainsKey(difficulty))
            {
                playTime[difficulty] = time;
            }
        }

        public string GetPlayTimeString(string difficulty)
        {
            if (!playTime.ContainsKey(difficulty))
            {
                return "--:--:--";
            }

            if (playTime[difficulty] < 0)
            {
                return "--:--:--";
            }

            int time = playTime[difficulty];
            int minute = time / 6000;
            time %= 6000;
            int second = time / 100;
            time %= 100;
            string addZeroToMinute = minute >= 10 ? "" : "0";
            string addZeroToSecond = second >= 10 ? "" : "0";
            string addZeroToMinusSecond = time >= 10 ? "" : "0";
            return $"{addZeroToMinute}{minute}:{addZeroToSecond}{second}:{addZeroToMinusSecond}{time}";
        }
    }
}
