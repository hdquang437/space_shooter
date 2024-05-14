namespace Space_Shooter.AccountManagement
{
    partial class LoginComponent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginComponent));
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_forgot_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.forgotPasswordComponent = new Space_Shooter.AccountManagement.ForgotPassword();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(85, 324);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(411, 35);
            this.tb_password.TabIndex = 6;
            this.tb_password.Enter += new System.EventHandler(this.tb_password_Enter);
            this.tb_password.Leave += new System.EventHandler(this.tb_password_Leave);
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(85, 232);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(411, 35);
            this.tb_email.TabIndex = 5;
            this.tb_email.Enter += new System.EventHandler(this.tb_email_Enter);
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.BackColor = System.Drawing.Color.Transparent;
            this.lb_Email.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.ForeColor = System.Drawing.Color.Crimson;
            this.lb_Email.Location = new System.Drawing.Point(80, 184);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(145, 27);
            this.lb_Email.TabIndex = 7;
            this.lb_Email.Text = "Email";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.BackColor = System.Drawing.Color.Transparent;
            this.lb_password.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.ForeColor = System.Drawing.Color.Crimson;
            this.lb_password.Location = new System.Drawing.Point(80, 282);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(216, 27);
            this.lb_password.TabIndex = 7;
            this.lb_password.Text = "Password";
            // 
            // lb_forgot_password
            // 
            this.lb_forgot_password.AutoSize = true;
            this.lb_forgot_password.BackColor = System.Drawing.Color.Transparent;
            this.lb_forgot_password.Font = new System.Drawing.Font("Unispace", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_forgot_password.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_forgot_password.Location = new System.Drawing.Point(355, 384);
            this.lb_forgot_password.Name = "lb_forgot_password";
            this.lb_forgot_password.Size = new System.Drawing.Size(143, 18);
            this.lb_forgot_password.TabIndex = 9;
            this.lb_forgot_password.Text = "Forgot password";
            this.lb_forgot_password.Click += new System.EventHandler(this.lb_forgot_password_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DimGray;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Khaki;
            this.btn_login.Location = new System.Drawing.Point(182, 433);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(215, 71);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "LOG IN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pb_exit
            // 
            this.pb_exit.BackColor = System.Drawing.Color.Transparent;
            this.pb_exit.Image = ((System.Drawing.Image)(resources.GetObject("pb_exit.Image")));
            this.pb_exit.Location = new System.Drawing.Point(0, 1);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(55, 50);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_exit.TabIndex = 11;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // forgotPasswordComponent
            // 
            this.forgotPasswordComponent.BackColor = System.Drawing.Color.Transparent;
            this.forgotPasswordComponent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forgotPasswordComponent.BackgroundImage")));
            this.forgotPasswordComponent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forgotPasswordComponent.Location = new System.Drawing.Point(0, 0);
            this.forgotPasswordComponent.Name = "forgotPasswordComponent";
            this.forgotPasswordComponent.Size = new System.Drawing.Size(1161, 676);
            this.forgotPasswordComponent.TabIndex = 12;
            this.forgotPasswordComponent.Visible = false;
            // 
            // LoginComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.forgotPasswordComponent);
            this.Controls.Add(this.pb_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_forgot_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_email);
            this.Name = "LoginComponent";
            this.Size = new System.Drawing.Size(1161, 676);
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_forgot_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pb_exit;
        private ForgotPassword forgotPasswordComponent;
    }
}
