using Space_Shooter.AccountManagement.Model;
using Space_Shooter.AccountManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.AccountManagement
{
    public partial class HomeScreen : Form
    {

        Point mouseLocation;

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

        public HomeScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pn_title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void pn_title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = System.Windows.Forms.Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
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
            Hide();
            Form1 game = new Form1();
            game.ShowDialog();
            
        }

        private void loginComponent_getUser(object sender, EventArgs e)
        {
            User user = sender as User;
            this.lb_userName.Text = user.name;
            this.lb_highestScoreValue.Text = user.highestScore.ToString();
            this.pb_avatar.Image = Image.FromFile(FilePathManager.GetFilePath("images") + user.avaPath);
            this.pn_user.Visible = true;
            this.btn_login.Visible = false;
            this.btn_signup.Visible = false;
            this.btn_start.Visible = true;
            this.btn_logout.Visible = true;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.btn_start.Visible = false;
            this.btn_logout.Visible = false;
            this.pn_user.Visible = false;
            this.btn_login.Visible = true;
            this.btn_signup.Visible = true;
        }

        void loadUser(User user, int i)
        {
            LeaderBoardUser leaderBoardUser = new LeaderBoardUser();
            leaderBoardUser.LoadData(i, user.avaPath, user.name, user.highestScore.ToString());
            this.fpn_leaderBoard.Controls.Add(leaderBoardUser);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            List<User> users = UserRepo.LoadUsersFromFile();
            users.Sort((o1, o2) => o1.highestScore < o2.highestScore ? 1 : 0);

            for (int i = 0; i < (users.Count >= 5 ? 5 : users.Count); i++)
            {
                loadUser(users[i], i);
            }
        }
    }
}
