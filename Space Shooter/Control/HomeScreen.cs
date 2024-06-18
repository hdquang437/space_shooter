using Space_Shooter.AccountManagement.Model;
using Space_Shooter.AccountManagement.Repository;
using Space_Shooter.Control;
using Space_Shooter.Manager;
using Space_Shooter.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.AccountManagement
{
    public partial class HomeScreen : UserControl
    {
        List<User> users = new List<User>();
        public User currentUser;
        public GameDifficulty currentDiff = GameDifficulty.Easy;
        public Ship currentShip = Ship.Default;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        LoginComponent loginComponent = null;
        SignUpComponent signUpComponent = null;
        Screen_SaveAndLoad loadSavefileComponent = null;

        public static GameDataManager GameDataManager = GameDataManager.Instance;

        public HomeScreen(User user)
        {
            InitializeComponent();
            Size formsize = new Size(1582, 1053);

            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, formsize.Width-200, formsize.Height-200, 20, 20));
            this.Dock = DockStyle.Fill;
            this.currentUser = user;

            btn_diff_easy.BackgroundImage = Properties.Resources.diff_button_active;
            btn_diff_normal.BackgroundImage = Properties.Resources.diff_button_inactive;
            btn_diff_hard.BackgroundImage = Properties.Resources.diff_button_inactive;

            //accountPagePlaceholder.BringToFront();
            //accountPagePlaceholder.Visible = false;

            loginComponent = new LoginComponent();
            signUpComponent = new SignUpComponent();
            loadSavefileComponent = new Screen_SaveAndLoad();
            loadSavefileComponent.mode = Screen_SaveAndLoad.Mode.Load;
            loadSavefileComponent.Visible = false;
            loginComponent.Visible = false;
            signUpComponent.Visible = false;
            Controls.Add(loginComponent);
            Controls.Add(signUpComponent);
            Controls.Add(loadSavefileComponent);
            loginComponent.BringToFront();
            signUpComponent.BringToFront();
            loadSavefileComponent.BringToFront();

            loginComponent.getUser += new EventHandler(loginComponent_getUser);
            signUpComponent.reloadUser += new EventHandler(signUpComponent_reloadUser);
            loadSavefileComponent.SaveAndLoadButton += new EventHandler(loadSavefileComponent_LoadProfile);
            loadSavefileComponent.backButton += new EventHandler(loadSavefileComponent_Back);

            pn_chooseShipDiff.Visible = true;
            pn_chooseShip.Visible = false;
            pn_Controller.Visible = false;
        }

        public event EventHandler StartGame;
        public event EventHandler ChooseShip;
        public event EventHandler SetDiff;
        public event EventHandler LoadGame;

        private void pb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (GameDataManager.init)
            {
                return;
            }
            Application.Exit();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            this.signUpComponent.Visible = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.loginComponent.Visible = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (GameDataManager.init)
            {
                return;
            }
            SetDiff(this, e);
            ChooseShip(this, e);
            StartGame(currentUser,e);
        }

        private void loginComponent_getUser(object sender, EventArgs e)
        {
            currentUser = sender as User;
            SaveFileManager.Instance.LoadSaveProfilesFromLocal(currentUser);
            this.lb_userName.Text = currentUser.name;
            this.lb_highestScoreValue.Text = currentUser.highestScore[GameDataManager.GetDifficultyStr.ToLower()].ToString();
            this.pb_avatar.Image = Image.FromFile(FilePathManager.GetFilePath("images") + currentUser.avaPath);
            this.pn_user.Visible = true;
            this.btn_login.Visible = false;
            this.btn_signup.Visible = false;
            this.btn_start.Visible = true;
            this.btn_logout.Visible = true;
            this.btn_continue.Visible = true;
            this.pn_chooseShip.Visible = true;
            this.pn_Controller.Visible = true;
        }

        private void loadSavefileComponent_Back(object sender, EventArgs e)
        {
            loadSavefileComponent.Visible = false;
        }

        private void loadSavefileComponent_LoadProfile(object sender, EventArgs e)
        {
            loadSavefileComponent.Visible = false;
            LoadGame(currentUser, e);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.btn_start.Visible = false;
            this.btn_logout.Visible = false;
            this.pn_user.Visible = false;
            this.btn_login.Visible = true;
            this.btn_signup.Visible = true;
            this.btn_continue.Visible = false;
            this.pn_chooseShip.Visible = false;
            this.pn_Controller.Visible = false;
        }

        void loadUser()
        {
            users.Clear();
            fpn_leaderBoard.Controls.Clear();
            users = UserRepo.LoadUsersFromFile();
            LeaderBoardUser.ImportAvatar(users);

            users.Sort((o1, o2) => Utilities.CompareUserResult(o1, o2, GameDataManager.GetDifficultyStr.ToLower()) * -1);
            for (int i = 0; i < (users.Count >= 10 ? 10 : users.Count); i++)
            {
                loadUserToView(users[i], i);
            }

        }
        private void loadUserToView(User user, int i)
        {
            string difficulty = GameDataManager.GetDifficultyStr.ToLower();
            LeaderBoardUser leaderBoardUser = new LeaderBoardUser();
            leaderBoardUser.LoadData(i, user.avaPath, user.name, user.highestScore[difficulty].ToString(), user.GetPlayTimeString(difficulty));
            this.fpn_leaderBoard.Controls.Add(leaderBoardUser);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            loadUser();
            if (currentUser != null)
            {
                this.lb_userName.Text = currentUser.name;
                this.lb_highestScoreValue.Text = currentUser.highestScore.ToString();
                this.pb_avatar.Image = Image.FromFile(FilePathManager.GetFilePath("images") + currentUser.avaPath);
                this.pn_user.Visible = true;
                this.btn_login.Visible = false;
                this.btn_signup.Visible = false;
                this.btn_start.Visible = true;
                this.btn_logout.Visible = true;
                this.pn_chooseShip.Visible = true;
                this.pn_Controller.Visible = true;
            }
        }

        private void signUpComponent_reloadUser(object sender, EventArgs e)
        {
            loadUser();
        }

        private void pb_currentShip_Click(object sender, EventArgs e)
        {
            fpn_chooseShip.Visible = !fpn_chooseShip.Visible;
        }

        private void pb_normalShip_Click(object sender, EventArgs e)
        {
            currentShip = Ship.Default;
            GameDataManager.playerShipType = currentShip;
            pb_currentShip.Image = Properties.Resources.char_SpaceshipNormal;
            fpn_chooseShip.Visible = false;
        }

        private void pb_Emissary_Click(object sender, EventArgs e)
        {
            currentShip = Ship.Emissary;
            GameDataManager.playerShipType = currentShip;
            pb_currentShip.Image = Properties.Resources.char_SpaceshipEmissary;
            fpn_chooseShip.Visible = false;
        }

        private void pb_beholder_Click(object sender, EventArgs e)
        {
            currentShip = Ship.Beholder;
            GameDataManager.playerShipType = currentShip;
            pb_currentShip.Image = Properties.Resources.char_SpaceshipBeholder;
            fpn_chooseShip.Visible = false;
        }

        private void btn_diff_easy_Click(object sender, EventArgs e)
        {
            if (currentDiff == GameDifficulty.Easy)
                return;
            currentDiff = GameDifficulty.Easy;
            GameDataManager.Difficulty = currentDiff;
            btn_diff_easy.BackgroundImage = Properties.Resources.diff_button_active;
            btn_diff_normal.BackgroundImage = Properties.Resources.diff_button_inactive;
            btn_diff_hard.BackgroundImage = Properties.Resources.diff_button_inactive;
            UpdateLeaderboard();
        }

        private void btn_diff_normal_Click(object sender, EventArgs e)
        {
            if (currentDiff == GameDifficulty.Normal)
                return;
            currentDiff = GameDifficulty.Normal;
            GameDataManager.Difficulty = currentDiff;
            btn_diff_easy.BackgroundImage = Properties.Resources.diff_button_inactive;
            btn_diff_normal.BackgroundImage = Properties.Resources.diff_button_active;
            btn_diff_hard.BackgroundImage = Properties.Resources.diff_button_inactive;
            UpdateLeaderboard();
        }

        private void btn_diff_hard_Click(object sender, EventArgs e)
        {
            if (currentDiff == GameDifficulty.Hard)
                return;
            currentDiff = GameDifficulty.Hard;
            GameDataManager.Difficulty = currentDiff;
            btn_diff_easy.BackgroundImage = Properties.Resources.diff_button_inactive;
            btn_diff_normal.BackgroundImage = Properties.Resources.diff_button_inactive;
            btn_diff_hard.BackgroundImage = Properties.Resources.diff_button_active;
            UpdateLeaderboard();
        }

        public void UpdateLeaderboard()
        {
            if (currentUser != null)
            {
                this.lb_highestScoreValue.Text = currentUser.highestScore[GameDataManager.GetDifficultyStr.ToLower()].ToString();
                int index = users.FindIndex(x => x.id == currentUser.id);
                if (index != -1)
                    users[index] = currentUser;
            }

            this.fpn_leaderBoard.Controls.Clear();

            users.Sort((o1, o2) => Utilities.CompareUserResult(o1, o2, GameDataManager.GetDifficultyStr.ToLower()) * -1);
            for (int i = 0; i < (users.Count >= 10 ? 10 : users.Count); i++)
            {
                loadUserToView(users[i], i);
            }
        }

        private void btn_controlMouse_Click(object sender, EventArgs e)
        {
            if (GameDataManager.playMode == PlayMode.Mouse)
                return;
            GameDataManager.playMode = PlayMode.Mouse;
            btn_controlMouse.BackgroundImage = Resources.controller_mouse_active;
            btn_controlKeyboard.BackgroundImage = Resources.controller_keyboard_deactive;
        }

        private void btn_controlKeyboard_Click(object sender, EventArgs e)
        {
            if (GameDataManager.playMode == PlayMode.Keyboard)
                return;
            GameDataManager.playMode = PlayMode.Keyboard;
            btn_controlMouse.BackgroundImage = Resources.controller_mouse_deactive;
            btn_controlKeyboard.BackgroundImage = Resources.controller_keyboard_active;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            if (GameDataManager.init)
            {
                return;
            }
            loadSavefileComponent.Setup(currentUser);
            loadSavefileComponent.BringToFront();
            loadSavefileComponent.Visible = true;
        }
    }
}
