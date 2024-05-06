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

        public void LoadData(int id, string avatarPath, string name, string score)
        {
            pb_avatar.BackgroundImage = Image.FromFile(avatarPath);
            lb_userName.Text = name;
            lb_highestScoreValue.Text = score;
            if (id == 0)
            {
                this.BackgroundImage = Image.FromFile(FilePathManager.GetFilePath("images") + "top_leaderBoard_bg.png");
            }
        }
    }
}
