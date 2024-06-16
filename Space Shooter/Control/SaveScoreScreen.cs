using Space_Shooter.AccountManagement.Model;
using Space_Shooter.AccountManagement.Repository;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.Control
{
    public partial class SaveScoreScreen : UserControl
    {

        string victorySentence = "Congrat! You beated the game!";
        string defeatedSentence = "Too bad! Better luck next time!";
        public User currentUser;

        public static readonly GameDataManager GameDataManger = GameDataManager.Instance;

        public SaveScoreScreen(User user)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.currentUser = user;
        }

        public event EventHandler BackButtonClick;

        private void btn_back_Click(object sender, EventArgs e)
        {
            BackButtonClick(sender, e);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.btn_back.Visible = false;
            this.btn_save.Visible = false;

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(Point.Empty, new Size(Screen_Game.REAL_SCREEN_WIDTH - 4, Screen_Game.REAL_SCREEN_HEIGHT)));
            DateTime time = DateTime.Now;
            string path = GameDataManager.SCREENSHOT_FOLDER_PATH + "user_" + currentUser.name + time.ToString("yyyyMMddHHmmss") + ".png";
            bmp.Save(path, ImageFormat.Png);
            MessageBox.Show("Your screenshot has been saved to: " + path);

            BackButtonClick(sender, e);
        }

        public void UpdateScreen()
        {
            pb_avatar.Image = Image.FromFile(FilePathManager.GetFilePath("images") + currentUser.avaPath);
            lb_userName.Text = currentUser.name;
            if (GameDataManger.GameEnd == true)
            {
                lb_senceten.Text = victorySentence;
                pb_victory.Image = Properties.Resources.victory_img;
            }
            else
            {
                pb_victory.Image = Properties.Resources.defeat_img;
                lb_senceten.Text = defeatedSentence;
            }
            lb_scoreVal.Text = GameDataManger.score.ToString();
            string difficulty = GameDataManger.GetDifficultyStr.ToLower();
            if (GameDataManger.score > currentUser.highestScore[difficulty])
            {
                lb_yourScore.Text = "New High Score";
            }
            else
            {
                lb_yourScore.Text = "Your Score";
            }
            lb_playtime.Text = "Play time: " + GameDataManger.PlayTimeStr;

            // Update user score
            if (currentUser.highestScore[difficulty] < GameDataManger.score)
            {
                UserRepo.UpdateScore(currentUser.email, GameDataManger.score, GameDataManger.PlayTime, difficulty);
                currentUser.SetHighestScore(difficulty, GameDataManger.score);
                currentUser.SetPlayTime(difficulty, GameDataManger.PlayTime);
            }
        }

        private void SaveScoreScreen_Load(object sender, EventArgs e)
        {
            UpdateScreen();
        }
    }
}
