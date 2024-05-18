namespace Space_Shooter.AccountManagement
{
    partial class SignUpComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpComponent));
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.pb_chooseAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_chooseAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.BackColor = System.Drawing.Color.Transparent;
            this.lb_password.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.ForeColor = System.Drawing.Color.Crimson;
            this.lb_password.Location = new System.Drawing.Point(237, 535);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(216, 27);
            this.lb_password.TabIndex = 14;
            this.lb_password.Text = "Password";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.BackColor = System.Drawing.Color.Transparent;
            this.lb_Email.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.ForeColor = System.Drawing.Color.Crimson;
            this.lb_Email.Location = new System.Drawing.Point(237, 379);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(145, 27);
            this.lb_Email.TabIndex = 15;
            this.lb_Email.Text = "Email";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(242, 589);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(507, 35);
            this.tb_password.TabIndex = 13;
            this.tb_password.Enter += new System.EventHandler(this.tb_password_Enter);
            this.tb_password.Leave += new System.EventHandler(this.tb_password_Leave);
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(242, 438);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(507, 35);
            this.tb_email.TabIndex = 12;
            this.tb_email.Enter += new System.EventHandler(this.tb_email_Enter);
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // pb_exit
            // 
            this.pb_exit.BackColor = System.Drawing.Color.Transparent;
            this.pb_exit.Image = ((System.Drawing.Image)(resources.GetObject("pb_exit.Image")));
            this.pb_exit.Location = new System.Drawing.Point(0, 0);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(55, 50);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_exit.TabIndex = 18;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // btn_signUp
            // 
            this.btn_signUp.BackColor = System.Drawing.Color.DimGray;
            this.btn_signUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_signUp.BackgroundImage")));
            this.btn_signUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_signUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_signUp.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signUp.ForeColor = System.Drawing.Color.Khaki;
            this.btn_signUp.Location = new System.Drawing.Point(336, 720);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(215, 71);
            this.btn_signUp.TabIndex = 17;
            this.btn_signUp.Text = "Sign Up";
            this.btn_signUp.UseVisualStyleBackColor = false;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(242, 287);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(507, 35);
            this.tb_name.TabIndex = 12;
            this.tb_name.Enter += new System.EventHandler(this.tb_user_name_Enter);
            this.tb_name.Leave += new System.EventHandler(this.tb_user_name_Leave);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.Color.Crimson;
            this.lb_name.Location = new System.Drawing.Point(237, 237);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(123, 27);
            this.lb_name.TabIndex = 15;
            this.lb_name.Text = "Name";
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.BackColor = System.Drawing.Color.Transparent;
            this.pb_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Avatar.Location = new System.Drawing.Point(825, 309);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(110, 97);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Avatar.TabIndex = 19;
            this.pb_Avatar.TabStop = false;
            this.pb_Avatar.Click += new System.EventHandler(this.pb_Avatar_Click);
            // 
            // pb_chooseAvatar
            // 
            this.pb_chooseAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pb_chooseAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_chooseAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pb_chooseAvatar.Image")));
            this.pb_chooseAvatar.Location = new System.Drawing.Point(906, 380);
            this.pb_chooseAvatar.Name = "pb_chooseAvatar";
            this.pb_chooseAvatar.Size = new System.Drawing.Size(43, 43);
            this.pb_chooseAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_chooseAvatar.TabIndex = 20;
            this.pb_chooseAvatar.TabStop = false;
            this.pb_chooseAvatar.Click += new System.EventHandler(this.pb_Avatar_Click);
            // 
            // SignUpComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pb_chooseAvatar);
            this.Controls.Add(this.pb_Avatar);
            this.Controls.Add(this.pb_exit);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_email);
            this.Name = "SignUpComponent";
            this.Size = new System.Drawing.Size(1582, 1053);
            this.Load += new System.EventHandler(this.SignUpComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_chooseAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.PictureBox pb_chooseAvatar;
    }
}
