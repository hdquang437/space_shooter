using Space_Shooter.AccountManagement.Model;
using Space_Shooter.AccountManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.AccountManagement
{
    public partial class LeaderBoardUser : UserControl
    {
        public LeaderBoardUser()
        {
            InitializeComponent();
        }

        public void LoadData(int id, string avatarPath, string name, string score, string playtime)
        {
            pb_avatar.BackgroundImage = AvatarStorage[avatarPath];
            lb_userName.Text = name;
            lb_highestScoreValue.Text = score;
            if (id == 0)
            {
                this.BackgroundImage = AvatarStorage["top_bg"];
            }
            lb_PlayTime.Text = playtime;
        }

        static public Dictionary<string, Image> AvatarStorage = new Dictionary<string, Image>();

        static public void ImportAvatar(List<User> users)
        {
            AvatarStorage.Clear();
            AvatarStorage.Add("top_bg", Image.FromFile(FilePathManager.GetFilePath("images") + "top_leaderBoard_bg.png"));
            foreach (User user in users)
            {
                Image image = Image.FromFile(FilePathManager.GetFilePath("images") + user.avaPath);
                AvatarStorage.Add(user.avaPath, image);
            }

        }

        static public void AddNewAvatar(string avatarPath)
        {
            Image image = Image.FromFile(FilePathManager.GetFilePath("images") + avatarPath);
            AvatarStorage.Add(avatarPath, image);
        }
    }
}
