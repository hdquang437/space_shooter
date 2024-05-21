using Space_Shooter.AccountManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Space_Shooter.AccountManagement.Model;

namespace Space_Shooter.AccountManagement
{
    public partial class ForgotPassword : UserControl
    {
        const String emailHintText = "Enter your email...";
        const String emailNotExistError = "Email Doesn't Exist!";
        const String emailSentSuccessNoti = "Email Sent Successfully! Check your email for the password!";
        const String emailInvalidError = "Invalid Email!";
        Color hintColor = Color.Khaki;
        public ForgotPassword()
        {
            InitializeComponent();
            tb_email.Text = emailHintText;
            tb_email.ForeColor = hintColor;
            this.Dock = DockStyle.Fill;
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
                tb_email.ForeColor = hintColor;
            }
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_sentPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputValidator.validateEmail(tb_email.Text))
                {
                    MessageBox.Show(emailInvalidError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!UserRepo.IsEmailExists(tb_email.Text))
                {
                    MessageBox.Show(emailNotExistError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string password = GetOldPassword(tb_email.Text.Trim());

                //nguoi gui
                MailMessage mail = new MailMessage();
                mail.From = new System.Net.Mail.MailAddress("hungttalop14@gmail.com");
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail.From.Address, "slljqdbmtixortku");
                smtp.Host = "smtp.gmail.com";

                //nguoi nhan
                mail.To.Add(new MailAddress(tb_email.Text.Trim()));
                mail.IsBodyHtml = true;
                mail.Subject = "Password Recovery";
                mail.Body = $"Your forgotten password is: {password}";


                smtp.Send(mail);
                UserRepo.UpdatePassword(tb_email.Text, password);
                MessageBox.Show(emailSentSuccessNoti, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string GetOldPassword(string texts)
        {
            User user = UserRepo.GetUserByEmail(texts);
            return user.password;
        }
    }
}
