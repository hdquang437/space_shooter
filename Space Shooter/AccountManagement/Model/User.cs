using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.AccountManagement.Model
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string avaPath { get; set; }
        public int highestScore { get; set; }

        public User()
        {
            highestScore = 0;
            name = "Unknown";
            password = "Unknown";
            email = "Unknown";
            avaPath = Repository.FilePathManager.GetFilePath("images") + "defaultAvatar.png";
        }

        public User(string fullName, string password, string email, string pathToAvatar, int highestScore)
        {
            name = fullName;
            this.password = password;
            this.email = email;
            avaPath = pathToAvatar;
            this.highestScore = highestScore;
        }
    }
}
