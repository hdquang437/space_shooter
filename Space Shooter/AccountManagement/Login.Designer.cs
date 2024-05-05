namespace Space_Shooter.AccountManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pn_title_bar = new System.Windows.Forms.Panel();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pn_user = new System.Windows.Forms.Panel();
            this.lb_userName = new System.Windows.Forms.Label();
            this.lb_highestscore = new System.Windows.Forms.Label();
            this.lb_highestScoreValue = new System.Windows.Forms.Label();
            this.pn_leaderBoard = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.Button();
            this.pn_title_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            this.pn_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_title_bar
            // 
            this.pn_title_bar.BackColor = System.Drawing.Color.DarkCyan;
            this.pn_title_bar.Controls.Add(this.pb_exit);
            this.pn_title_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_title_bar.Location = new System.Drawing.Point(0, 0);
            this.pn_title_bar.Name = "pn_title_bar";
            this.pn_title_bar.Size = new System.Drawing.Size(1161, 50);
            this.pn_title_bar.TabIndex = 0;
            this.pn_title_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_title_bar_MouseDown);
            this.pn_title_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_title_bar_MouseMove);
            // 
            // pb_exit
            // 
            this.pb_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_exit.Image = ((System.Drawing.Image)(resources.GetObject("pb_exit.Image")));
            this.pb_exit.Location = new System.Drawing.Point(1106, 0);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(55, 50);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_exit.TabIndex = 0;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DimGray;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Khaki;
            this.btn_login.Location = new System.Drawing.Point(477, 245);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(215, 71);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.DimGray;
            this.btn_signup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_signup.BackgroundImage")));
            this.btn_signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_signup.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.Khaki;
            this.btn_signup.Location = new System.Drawing.Point(477, 343);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(215, 71);
            this.btn_signup.TabIndex = 1;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DimGray;
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Khaki;
            this.btn_exit.Location = new System.Drawing.Point(477, 447);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(215, 71);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pn_user
            // 
            this.pn_user.Controls.Add(this.lb_highestScoreValue);
            this.pn_user.Controls.Add(this.lb_highestscore);
            this.pn_user.Controls.Add(this.lb_userName);
            this.pn_user.Location = new System.Drawing.Point(0, 50);
            this.pn_user.Name = "pn_user";
            this.pn_user.Size = new System.Drawing.Size(463, 184);
            this.pn_user.TabIndex = 2;
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userName.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_userName.Location = new System.Drawing.Point(12, 17);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(346, 41);
            this.lb_userName.TabIndex = 0;
            this.lb_userName.Text = "User Name";
            // 
            // lb_highestscore
            // 
            this.lb_highestscore.AutoSize = true;
            this.lb_highestscore.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_highestscore.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lb_highestscore.Location = new System.Drawing.Point(12, 80);
            this.lb_highestscore.Name = "lb_highestscore";
            this.lb_highestscore.Size = new System.Drawing.Size(335, 27);
            this.lb_highestscore.TabIndex = 0;
            this.lb_highestscore.Text = "Highest Score:";
            // 
            // lb_highestScoreValue
            // 
            this.lb_highestScoreValue.AutoSize = true;
            this.lb_highestScoreValue.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_highestScoreValue.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lb_highestScoreValue.Location = new System.Drawing.Point(12, 116);
            this.lb_highestScoreValue.Name = "lb_highestScoreValue";
            this.lb_highestScoreValue.Size = new System.Drawing.Size(97, 27);
            this.lb_highestScoreValue.TabIndex = 0;
            this.lb_highestScoreValue.Text = "10000";
            // 
            // pn_leaderBoard
            // 
            this.pn_leaderBoard.Location = new System.Drawing.Point(857, 59);
            this.pn_leaderBoard.Name = "pn_leaderBoard";
            this.pn_leaderBoard.Size = new System.Drawing.Size(291, 483);
            this.pn_leaderBoard.TabIndex = 3;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.DimGray;
            this.btn_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_start.BackgroundImage")));
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.Khaki;
            this.btn_start.Location = new System.Drawing.Point(477, 245);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(215, 71);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1161, 726);
            this.Controls.Add(this.pn_leaderBoard);
            this.Controls.Add(this.pn_user);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pn_title_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.pn_title_bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.pn_user.ResumeLayout(false);
            this.pn_user.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_title_bar;
        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel pn_user;
        private System.Windows.Forms.Label lb_highestScoreValue;
        private System.Windows.Forms.Label lb_highestscore;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Panel pn_leaderBoard;
        private System.Windows.Forms.Button btn_start;
    }
}