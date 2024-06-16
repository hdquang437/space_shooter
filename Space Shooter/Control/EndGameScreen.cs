using Space_Shooter.AccountManagement.Model;
using Space_Shooter.AccountManagement.Repository;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.Control
{
    public partial class EndGameScreen : UserControl
    {
        string victorySentence = "Congrat! You beated the game!";
        string defeatedSentence = "Too bad! Better luck next time!";
        public User currentUser;

        private SaveScoreScreen saveScoreScreen;

        static public readonly GameDataManager GameDataManager = GameDataManager.Instance;

        public EndGameScreen(User user)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.currentUser = user;

            saveScoreScreen = new SaveScoreScreen();
            saveScoreScreen.BackButtonClick += new EventHandler(SaveScoreScreen_Close);
            Controls.Add(saveScoreScreen);
            saveScoreScreen.Visible = false;
            saveScoreScreen.BringToFront();

        }

        private void EndGameScreen_Load(object sender, EventArgs e)
        {
            //UpdateScreen();
        }

        public void UpdateScreen()
        {
            pb_avatar.Image = Image.FromFile(FilePathManager.GetFilePath("images") + currentUser.avaPath);
            lb_userName.Text = currentUser.name;
            if (GameDataManager.GameEnd == true)
            {
                lb_senceten.Text = victorySentence;
                pb_victory.Image = Properties.Resources.victory_img;
            }
            else
            {
                pb_victory.Image = Properties.Resources.defeat_img;
                lb_senceten.Text = defeatedSentence;
            }
            lb_scoreVal.Text = GameDataManager.score.ToString();
            string difficulty = GameDataManager.GetDifficultyStr.ToLower();
            if (GameDataManager.score > currentUser.highestScore[difficulty])
            {
                lb_yourScore.Text = "New High Score";
            }
            else
            {
                lb_yourScore.Text = "Your Score";
            }
            lb_playtime.Text = "Play time: " + GameDataManager.PlayTimeStr;

            // Update user score
            if (currentUser.highestScore[difficulty] < GameDataManager.score)
            {
                UserRepo.UpdateScore(currentUser.email, GameDataManager.score, GameDataManager.PlayTime, difficulty);
                currentUser.SetHighestScore(difficulty, GameDataManager.score);
                currentUser.SetPlayTime(difficulty, GameDataManager.PlayTime);
            }
        }

        public event EventHandler GoToMainMenu;
        public event EventHandler Continue;

        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            GoToMainMenu(this, e);
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            Continue(this, e);
        }

        private void btn_share_Click(object sender, EventArgs e)
        {
            saveScoreScreen.UpdateScreen(currentUser);
            saveScoreScreen.Visible = true;
        }

        public void SaveScoreScreen_Close(object sender, EventArgs e)
        {
            saveScoreScreen.Visible = false;
        }
    }
}
