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
    public partial class LoginComponent : UserControl
    {
        const String emailHintText = "Enter your email...";
        const String passwordHintText = "Enter your password...";
        const String inputInvalidNoti = "Your email and password are not in correct format!";
        const String logInFailedNoti = "Incorrect Email or Password!";
        public LoginComponent()
        {
            InitializeComponent();
            tb_email.Text = emailHintText;
            tb_email.ForeColor = Color.Khaki;
            tb_password.Text = passwordHintText;
            tb_password.ForeColor = Color.Khaki;
            tb_password.PasswordChar = '\0';
        }

        public event EventHandler getUser; 

        private void tb_email_Enter(object sender, EventArgs e)
        {
            if (tb_email.Text == emailHintText)
            {
                tb_email.Text = "";
                tb_email.ForeColor = this.ForeColor;
            }
        }

        private void tb_email_Leave(object sender, EventArgs e)
        {
            if (tb_email.Text == "")
            {
                tb_email.Text = emailHintText;
                tb_email.ForeColor = Color.Khaki;
            }
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == passwordHintText)
            {
                tb_password.Text = "";
                tb_password.ForeColor = this.ForeColor;
                tb_password.PasswordChar = '*';
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.Text = passwordHintText;
                tb_password.ForeColor = Color.Khaki;
                tb_password.PasswordChar = '\0';
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text;
            string password = tb_password.Text;
            email = email.Trim();
            password = password.Trim();

            if (InputValidator.validateEmail(email) == false
                || InputValidator.validatePassword(password) == false)
            {
                MessageBox.Show(inputInvalidNoti);
                return;
            }
            User user = UserRepo.Login(email, password);
            if (user != null)
            {
                this.Visible = false;
                getUser(user, e);
            }
            else
            {
                MessageBox.Show(logInFailedNoti);
            }
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void lb_forgot_password_Click(object sender, EventArgs e)
        {

        }
    }
}
