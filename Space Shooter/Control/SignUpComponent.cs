using Space_Shooter.AccountManagement.Model;
using Space_Shooter.AccountManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.AccountManagement
{
    public partial class SignUpComponent : UserControl
    {
        private string avarPath = "";
        private string userNameHintText = "Enter your name...";
        private string passwordHintText = "Enter your password...";
        private string emailHintText = "Enter your email...";
        private string emailExistError = "This email is used!";
        private string createSuccessNoti = "Sign up success! You can now login!";
        private string inputErrorNoti = "Email and password are not in correct format!";
        public SignUpComponent()
        {
            InitializeComponent();
            tb_name.Text = userNameHintText;
            tb_name.ForeColor = Color.Khaki;
            tb_email.Text = emailHintText;
            tb_email.ForeColor = Color.Khaki;
            tb_password.Text = passwordHintText;
            tb_password.ForeColor = Color.Khaki;
            tb_password.PasswordChar = '\0';
            this.Dock = DockStyle.Fill;
        }
        public event EventHandler reloadUser;

        private void pb_Avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avarPath = openFileDialog.FileName;
                pb_Avatar.Image = Image.FromFile(avarPath);
            }

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (InputValidator.validateEmail(tb_email.Text) == false ||
                InputValidator.validatePassword(tb_password.Text) == false ||
                InputValidator.validateName(tb_name.Text) == false)
            {
                MessageBox.Show(inputErrorNoti);
                return;
            }

            if (UserRepo.IsEmailExists(tb_email.Text))
            {
                MessageBox.Show(emailExistError);
                return;
            }

            User newUser = UserRepo.AddUser(tb_name.Text.Trim(), tb_password.Text.Trim(), tb_email.Text.Trim(), avarPath, 0);
            CopyToStorage(avarPath, newUser.id);
            MessageBox.Show(createSuccessNoti);
            reloadUser(newUser, e);
            this.Visible = false;
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void tb_user_name_Enter(object sender, EventArgs e)
        {
            if (tb_name.Text == userNameHintText)
            {
                tb_name.Text = "";
                tb_name.ForeColor = this.ForeColor;
            }
        }

        private void tb_user_name_Leave(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                tb_name.Text = userNameHintText;
                tb_name.ForeColor = Color.Khaki;
            }
        }
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

        private void SignUpComponent_Load(object sender, EventArgs e)
        {
            avarPath = FilePathManager.GetFilePath("images") + "defaultAvatar.png";
            pb_Avatar.Image = Image.FromFile(avarPath);
        }

        private String CopyToStorage(string avaPath, int userID)
        {
            string fileExtension = Path.GetExtension(avaPath);
            string destPath = FilePathManager.GetFilePath("images") + userID + fileExtension;
            try
            {
                File.Copy(avaPath, destPath, true);
                return destPath;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
