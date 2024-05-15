namespace Space_Shooter.AccountManagement
{
    partial class HomeScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_userName = new System.Windows.Forms.Label();
            this.lb_highestscore = new System.Windows.Forms.Label();
            this.lb_highestScoreValue = new System.Windows.Forms.Label();
            this.pn_user = new System.Windows.Forms.Panel();
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            this.fpn_leaderBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_leaderBoard = new System.Windows.Forms.Panel();
            this.pn_title_bar = new System.Windows.Forms.Panel();
            this.loginComponent = new Space_Shooter.AccountManagement.LoginComponent();
            this.signUpComponent = new Space_Shooter.AccountManagement.SignUpComponent();
            this.pn_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            this.pn_leaderBoard.SuspendLayout();
            this.pn_title_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DimGray;
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Khaki;
            this.btn_exit.Location = new System.Drawing.Point(866, 664);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(304, 101);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DimGray;
            this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Khaki;
            this.btn_logout.Location = new System.Drawing.Point(866, 499);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(304, 101);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Visible = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.DimGray;
            this.btn_signup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_signup.BackgroundImage")));
            this.btn_signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_signup.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.Khaki;
            this.btn_signup.Location = new System.Drawing.Point(866, 499);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(304, 101);
            this.btn_signup.TabIndex = 1;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.DimGray;
            this.btn_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_start.BackgroundImage")));
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.Khaki;
            this.btn_start.Location = new System.Drawing.Point(866, 329);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(304, 101);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Visible = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DimGray;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Khaki;
            this.btn_login.Location = new System.Drawing.Point(866, 329);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(304, 101);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_userName.ForeColor = System.Drawing.Color.SpringGreen;
            this.lb_userName.Location = new System.Drawing.Point(62, 166);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(301, 41);
            this.lb_userName.TabIndex = 0;
            this.lb_userName.Text = "font chữ tiếng việt ";
            // 
            // lb_highestscore
            // 
            this.lb_highestscore.AutoSize = true;
            this.lb_highestscore.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_highestscore.ForeColor = System.Drawing.Color.Gold;
            this.lb_highestscore.Location = new System.Drawing.Point(66, 220);
            this.lb_highestscore.Name = "lb_highestscore";
            this.lb_highestscore.Size = new System.Drawing.Size(335, 27);
            this.lb_highestscore.TabIndex = 0;
            this.lb_highestscore.Text = "Highest Score:";
            // 
            // lb_highestScoreValue
            // 
            this.lb_highestScoreValue.AutoSize = true;
            this.lb_highestScoreValue.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_highestScoreValue.ForeColor = System.Drawing.Color.Gold;
            this.lb_highestScoreValue.Location = new System.Drawing.Point(64, 250);
            this.lb_highestScoreValue.Name = "lb_highestScoreValue";
            this.lb_highestScoreValue.Size = new System.Drawing.Size(97, 27);
            this.lb_highestScoreValue.TabIndex = 0;
            this.lb_highestScoreValue.Text = "10000";
            // 
            // pn_user
            // 
            this.pn_user.BackColor = System.Drawing.Color.Transparent;
            this.pn_user.Controls.Add(this.pb_avatar);
            this.pn_user.Controls.Add(this.lb_highestScoreValue);
            this.pn_user.Controls.Add(this.lb_highestscore);
            this.pn_user.Controls.Add(this.lb_userName);
            this.pn_user.Location = new System.Drawing.Point(12, 55);
            this.pn_user.Name = "pn_user";
            this.pn_user.Size = new System.Drawing.Size(804, 332);
            this.pn_user.TabIndex = 2;
            this.pn_user.Visible = false;
            // 
            // pb_avatar
            // 
            this.pb_avatar.Location = new System.Drawing.Point(71, 35);
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.Size = new System.Drawing.Size(128, 119);
            this.pb_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_avatar.TabIndex = 1;
            this.pb_avatar.TabStop = false;
            // 
            // fpn_leaderBoard
            // 
            this.fpn_leaderBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpn_leaderBoard.AutoSize = true;
            this.fpn_leaderBoard.BackColor = System.Drawing.Color.Transparent;
            this.fpn_leaderBoard.Location = new System.Drawing.Point(32, 176);
            this.fpn_leaderBoard.Name = "fpn_leaderBoard";
            this.fpn_leaderBoard.Size = new System.Drawing.Size(394, 744);
            this.fpn_leaderBoard.TabIndex = 3;
            // 
            // pn_leaderBoard
            // 
            this.pn_leaderBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_leaderBoard.BackColor = System.Drawing.Color.Transparent;
            this.pn_leaderBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_leaderBoard.BackgroundImage")));
            this.pn_leaderBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_leaderBoard.Controls.Add(this.fpn_leaderBoard);
            this.pn_leaderBoard.Location = new System.Drawing.Point(1108, 75);
            this.pn_leaderBoard.Name = "pn_leaderBoard";
            this.pn_leaderBoard.Size = new System.Drawing.Size(454, 948);
            this.pn_leaderBoard.TabIndex = 4;
            // 
            // pn_title_bar
            // 
            this.pn_title_bar.BackColor = System.Drawing.Color.DarkCyan;
            this.pn_title_bar.Controls.Add(this.loginComponent);
            this.pn_title_bar.Controls.Add(this.signUpComponent);
            this.pn_title_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_title_bar.Location = new System.Drawing.Point(0, 0);
            this.pn_title_bar.Name = "pn_title_bar";
            this.pn_title_bar.Size = new System.Drawing.Size(1582, 50);
            this.pn_title_bar.TabIndex = 0;
            // 
            // loginComponent
            // 
            this.loginComponent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginComponent.BackgroundImage")));
            this.loginComponent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginComponent.Location = new System.Drawing.Point(0, 0);
            this.loginComponent.Name = "loginComponent";
            this.loginComponent.Size = new System.Drawing.Size(1582, 50);
            this.loginComponent.TabIndex = 6;
            this.loginComponent.Visible = false;
            this.loginComponent.getUser += new System.EventHandler(this.loginComponent_getUser);
            // 
            // signUpComponent
            // 
            this.signUpComponent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUpComponent.BackgroundImage")));
            this.signUpComponent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signUpComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signUpComponent.Location = new System.Drawing.Point(0, 0);
            this.signUpComponent.Name = "signUpComponent";
            this.signUpComponent.Size = new System.Drawing.Size(1582, 50);
            this.signUpComponent.TabIndex = 7;
            this.signUpComponent.Visible = false;
            this.signUpComponent.reloadUser += new System.EventHandler(this.signUpComponent_reloadUser);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pn_leaderBoard);
            this.Controls.Add(this.pn_user);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pn_title_bar);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(1582, 1053);
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.pn_user.ResumeLayout(false);
            this.pn_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            this.pn_leaderBoard.ResumeLayout(false);
            this.pn_leaderBoard.PerformLayout();
            this.pn_title_bar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label lb_highestscore;
        private System.Windows.Forms.Label lb_highestScoreValue;
        private System.Windows.Forms.Panel pn_user;
        private System.Windows.Forms.PictureBox pb_avatar;
        private System.Windows.Forms.FlowLayoutPanel fpn_leaderBoard;
        private System.Windows.Forms.Panel pn_leaderBoard;
        private System.Windows.Forms.Panel pn_title_bar;
        private LoginComponent loginComponent;
        private SignUpComponent signUpComponent;
    }
}