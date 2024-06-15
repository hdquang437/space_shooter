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
            this.lb_chooseShip = new System.Windows.Forms.Label();
            this.pb_currentShip = new System.Windows.Forms.PictureBox();
            this.fpn_chooseShip = new System.Windows.Forms.FlowLayoutPanel();
            this.pb_normalShip = new System.Windows.Forms.PictureBox();
            this.pb_Emissary = new System.Windows.Forms.PictureBox();
            this.pb_beholder = new System.Windows.Forms.PictureBox();
            this.lb_setDiff = new System.Windows.Forms.Label();
            this.pn_currentShip = new System.Windows.Forms.Panel();
            this.btn_diff_easy = new System.Windows.Forms.Button();
            this.btn_diff_normal = new System.Windows.Forms.Button();
            this.btn_diff_hard = new System.Windows.Forms.Button();
            this.pn_chooseShipDiff = new System.Windows.Forms.Panel();
            this.pn_chooseShip = new System.Windows.Forms.Panel();
            this.btn_continue = new System.Windows.Forms.Button();
            this.pn_Controller = new System.Windows.Forms.Panel();
            this.btn_controlKeyboard = new System.Windows.Forms.Button();
            this.btn_controlMouse = new System.Windows.Forms.Button();
            this.lb_ChooseMode = new System.Windows.Forms.Label();
            this.pn_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            this.pn_leaderBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_currentShip)).BeginInit();
            this.fpn_chooseShip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_normalShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Emissary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_beholder)).BeginInit();
            this.pn_currentShip.SuspendLayout();
            this.pn_chooseShipDiff.SuspendLayout();
            this.pn_chooseShip.SuspendLayout();
            this.pn_Controller.SuspendLayout();
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
            this.btn_exit.TabIndex = 10;
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
            this.btn_logout.Location = new System.Drawing.Point(866, 544);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(304, 101);
            this.btn_logout.TabIndex = 3;
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
            this.btn_signup.TabIndex = 2;
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
            this.btn_start.Location = new System.Drawing.Point(866, 304);
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
            this.lb_userName.Size = new System.Drawing.Size(291, 40);
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
            this.fpn_leaderBoard.Location = new System.Drawing.Point(24, 146);
            this.fpn_leaderBoard.Name = "fpn_leaderBoard";
            this.fpn_leaderBoard.Size = new System.Drawing.Size(402, 737);
            this.fpn_leaderBoard.TabIndex = 3;
            // 
            // pn_leaderBoard
            // 
            this.pn_leaderBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_leaderBoard.BackColor = System.Drawing.Color.Transparent;
            this.pn_leaderBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_leaderBoard.BackgroundImage")));
            this.pn_leaderBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_leaderBoard.Controls.Add(this.fpn_leaderBoard);
            this.pn_leaderBoard.Location = new System.Drawing.Point(1106, 26);
            this.pn_leaderBoard.Name = "pn_leaderBoard";
            this.pn_leaderBoard.Size = new System.Drawing.Size(454, 910);
            this.pn_leaderBoard.TabIndex = 4;
            // 
            // lb_chooseShip
            // 
            this.lb_chooseShip.AutoSize = true;
            this.lb_chooseShip.BackColor = System.Drawing.Color.Transparent;
            this.lb_chooseShip.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chooseShip.ForeColor = System.Drawing.Color.Gold;
            this.lb_chooseShip.Location = new System.Drawing.Point(22, 49);
            this.lb_chooseShip.Name = "lb_chooseShip";
            this.lb_chooseShip.Size = new System.Drawing.Size(389, 27);
            this.lb_chooseShip.TabIndex = 8;
            this.lb_chooseShip.Text = "Choose your ship";
            // 
            // pb_currentShip
            // 
            this.pb_currentShip.BackColor = System.Drawing.Color.Transparent;
            this.pb_currentShip.Image = ((System.Drawing.Image)(resources.GetObject("pb_currentShip.Image")));
            this.pb_currentShip.Location = new System.Drawing.Point(0, 0);
            this.pb_currentShip.Name = "pb_currentShip";
            this.pb_currentShip.Size = new System.Drawing.Size(100, 93);
            this.pb_currentShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_currentShip.TabIndex = 9;
            this.pb_currentShip.TabStop = false;
            this.pb_currentShip.Click += new System.EventHandler(this.pb_currentShip_Click);
            // 
            // fpn_chooseShip
            // 
            this.fpn_chooseShip.BackColor = System.Drawing.Color.Transparent;
            this.fpn_chooseShip.BackgroundImage = global::Space_Shooter.Properties.Resources.ship_border;
            this.fpn_chooseShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fpn_chooseShip.Controls.Add(this.pb_normalShip);
            this.fpn_chooseShip.Controls.Add(this.pb_Emissary);
            this.fpn_chooseShip.Controls.Add(this.pb_beholder);
            this.fpn_chooseShip.Location = new System.Drawing.Point(180, 104);
            this.fpn_chooseShip.Name = "fpn_chooseShip";
            this.fpn_chooseShip.Size = new System.Drawing.Size(320, 99);
            this.fpn_chooseShip.TabIndex = 10;
            this.fpn_chooseShip.Visible = false;
            // 
            // pb_normalShip
            // 
            this.pb_normalShip.Image = ((System.Drawing.Image)(resources.GetObject("pb_normalShip.Image")));
            this.pb_normalShip.Location = new System.Drawing.Point(3, 3);
            this.pb_normalShip.Name = "pb_normalShip";
            this.pb_normalShip.Size = new System.Drawing.Size(100, 93);
            this.pb_normalShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_normalShip.TabIndex = 9;
            this.pb_normalShip.TabStop = false;
            this.pb_normalShip.Click += new System.EventHandler(this.pb_normalShip_Click);
            // 
            // pb_Emissary
            // 
            this.pb_Emissary.Image = ((System.Drawing.Image)(resources.GetObject("pb_Emissary.Image")));
            this.pb_Emissary.Location = new System.Drawing.Point(109, 3);
            this.pb_Emissary.Name = "pb_Emissary";
            this.pb_Emissary.Size = new System.Drawing.Size(100, 93);
            this.pb_Emissary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Emissary.TabIndex = 9;
            this.pb_Emissary.TabStop = false;
            this.pb_Emissary.Click += new System.EventHandler(this.pb_Emissary_Click);
            // 
            // pb_beholder
            // 
            this.pb_beholder.Image = ((System.Drawing.Image)(resources.GetObject("pb_beholder.Image")));
            this.pb_beholder.Location = new System.Drawing.Point(215, 3);
            this.pb_beholder.Name = "pb_beholder";
            this.pb_beholder.Size = new System.Drawing.Size(100, 93);
            this.pb_beholder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_beholder.TabIndex = 9;
            this.pb_beholder.TabStop = false;
            this.pb_beholder.Click += new System.EventHandler(this.pb_beholder_Click);
            // 
            // lb_setDiff
            // 
            this.lb_setDiff.AutoSize = true;
            this.lb_setDiff.BackColor = System.Drawing.Color.Transparent;
            this.lb_setDiff.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_setDiff.ForeColor = System.Drawing.Color.Gold;
            this.lb_setDiff.Location = new System.Drawing.Point(22, 239);
            this.lb_setDiff.Name = "lb_setDiff";
            this.lb_setDiff.Size = new System.Drawing.Size(338, 27);
            this.lb_setDiff.TabIndex = 8;
            this.lb_setDiff.Text = "Set Difficulty";
            // 
            // pn_currentShip
            // 
            this.pn_currentShip.BackColor = System.Drawing.Color.Transparent;
            this.pn_currentShip.BackgroundImage = global::Space_Shooter.Properties.Resources.ship_border;
            this.pn_currentShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_currentShip.Controls.Add(this.pb_currentShip);
            this.pn_currentShip.Location = new System.Drawing.Point(42, 104);
            this.pn_currentShip.Name = "pn_currentShip";
            this.pn_currentShip.Size = new System.Drawing.Size(101, 96);
            this.pn_currentShip.TabIndex = 11;
            // 
            // btn_diff_easy
            // 
            this.btn_diff_easy.BackColor = System.Drawing.Color.Transparent;
            this.btn_diff_easy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_diff_easy.BackgroundImage")));
            this.btn_diff_easy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_diff_easy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_diff_easy.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diff_easy.ForeColor = System.Drawing.Color.Khaki;
            this.btn_diff_easy.Location = new System.Drawing.Point(46, 296);
            this.btn_diff_easy.Name = "btn_diff_easy";
            this.btn_diff_easy.Size = new System.Drawing.Size(199, 61);
            this.btn_diff_easy.TabIndex = 12;
            this.btn_diff_easy.Text = "Easy";
            this.btn_diff_easy.UseVisualStyleBackColor = false;
            this.btn_diff_easy.Click += new System.EventHandler(this.btn_diff_easy_Click);
            // 
            // btn_diff_normal
            // 
            this.btn_diff_normal.BackColor = System.Drawing.Color.Transparent;
            this.btn_diff_normal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_diff_normal.BackgroundImage")));
            this.btn_diff_normal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_diff_normal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_diff_normal.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diff_normal.ForeColor = System.Drawing.Color.Khaki;
            this.btn_diff_normal.Location = new System.Drawing.Point(268, 296);
            this.btn_diff_normal.Name = "btn_diff_normal";
            this.btn_diff_normal.Size = new System.Drawing.Size(199, 61);
            this.btn_diff_normal.TabIndex = 12;
            this.btn_diff_normal.Text = "Normal";
            this.btn_diff_normal.UseVisualStyleBackColor = false;
            this.btn_diff_normal.Click += new System.EventHandler(this.btn_diff_normal_Click);
            // 
            // btn_diff_hard
            // 
            this.btn_diff_hard.BackColor = System.Drawing.Color.Transparent;
            this.btn_diff_hard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_diff_hard.BackgroundImage")));
            this.btn_diff_hard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_diff_hard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_diff_hard.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diff_hard.ForeColor = System.Drawing.Color.Khaki;
            this.btn_diff_hard.Location = new System.Drawing.Point(482, 296);
            this.btn_diff_hard.Name = "btn_diff_hard";
            this.btn_diff_hard.Size = new System.Drawing.Size(199, 61);
            this.btn_diff_hard.TabIndex = 12;
            this.btn_diff_hard.Text = "Hard";
            this.btn_diff_hard.UseVisualStyleBackColor = false;
            this.btn_diff_hard.Click += new System.EventHandler(this.btn_diff_hard_Click);
            // 
            // pn_chooseShipDiff
            // 
            this.pn_chooseShipDiff.BackColor = System.Drawing.Color.Transparent;
            this.pn_chooseShipDiff.Controls.Add(this.pn_chooseShip);
            this.pn_chooseShipDiff.Controls.Add(this.btn_diff_hard);
            this.pn_chooseShipDiff.Controls.Add(this.btn_diff_normal);
            this.pn_chooseShipDiff.Controls.Add(this.btn_diff_easy);
            this.pn_chooseShipDiff.Controls.Add(this.lb_setDiff);
            this.pn_chooseShipDiff.Location = new System.Drawing.Point(12, 615);
            this.pn_chooseShipDiff.Name = "pn_chooseShipDiff";
            this.pn_chooseShipDiff.Size = new System.Drawing.Size(701, 419);
            this.pn_chooseShipDiff.TabIndex = 13;
            this.pn_chooseShipDiff.Visible = false;
            // 
            // pn_chooseShip
            // 
            this.pn_chooseShip.Controls.Add(this.lb_chooseShip);
            this.pn_chooseShip.Controls.Add(this.pn_currentShip);
            this.pn_chooseShip.Controls.Add(this.fpn_chooseShip);
            this.pn_chooseShip.Location = new System.Drawing.Point(3, 3);
            this.pn_chooseShip.Name = "pn_chooseShip";
            this.pn_chooseShip.Size = new System.Drawing.Size(698, 213);
            this.pn_chooseShip.TabIndex = 13;
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.DimGray;
            this.btn_continue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_continue.BackgroundImage")));
            this.btn_continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_continue.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.ForeColor = System.Drawing.Color.Khaki;
            this.btn_continue.Location = new System.Drawing.Point(866, 424);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(304, 101);
            this.btn_continue.TabIndex = 14;
            this.btn_continue.Text = "CONTINUE";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Visible = false;
            // 
            // pn_Controller
            // 
            this.pn_Controller.BackColor = System.Drawing.Color.Transparent;
            this.pn_Controller.Controls.Add(this.btn_controlKeyboard);
            this.pn_Controller.Controls.Add(this.btn_controlMouse);
            this.pn_Controller.Controls.Add(this.lb_ChooseMode);
            this.pn_Controller.Location = new System.Drawing.Point(4, 443);
            this.pn_Controller.Name = "pn_Controller";
            this.pn_Controller.Size = new System.Drawing.Size(451, 166);
            this.pn_Controller.TabIndex = 15;
            // 
            // btn_controlKeyboard
            // 
            this.btn_controlKeyboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_controlKeyboard.BackgroundImage = global::Space_Shooter.Properties.Resources.controller_keyboard_deactive;
            this.btn_controlKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_controlKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_controlKeyboard.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_controlKeyboard.ForeColor = System.Drawing.Color.Khaki;
            this.btn_controlKeyboard.Location = new System.Drawing.Point(184, 44);
            this.btn_controlKeyboard.Name = "btn_controlKeyboard";
            this.btn_controlKeyboard.Size = new System.Drawing.Size(110, 110);
            this.btn_controlKeyboard.TabIndex = 15;
            this.btn_controlKeyboard.UseVisualStyleBackColor = false;
            this.btn_controlKeyboard.Click += new System.EventHandler(this.btn_controlKeyboard_Click);
            // 
            // btn_controlMouse
            // 
            this.btn_controlMouse.BackColor = System.Drawing.Color.Transparent;
            this.btn_controlMouse.BackgroundImage = global::Space_Shooter.Properties.Resources.controller_mouse_active;
            this.btn_controlMouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_controlMouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_controlMouse.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_controlMouse.ForeColor = System.Drawing.Color.Khaki;
            this.btn_controlMouse.Location = new System.Drawing.Point(51, 44);
            this.btn_controlMouse.Name = "btn_controlMouse";
            this.btn_controlMouse.Size = new System.Drawing.Size(110, 110);
            this.btn_controlMouse.TabIndex = 14;
            this.btn_controlMouse.UseVisualStyleBackColor = false;
            this.btn_controlMouse.Click += new System.EventHandler(this.btn_controlMouse_Click);
            // 
            // lb_ChooseMode
            // 
            this.lb_ChooseMode.AutoSize = true;
            this.lb_ChooseMode.BackColor = System.Drawing.Color.Transparent;
            this.lb_ChooseMode.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChooseMode.ForeColor = System.Drawing.Color.Gold;
            this.lb_ChooseMode.Location = new System.Drawing.Point(33, 11);
            this.lb_ChooseMode.Name = "lb_ChooseMode";
            this.lb_ChooseMode.Size = new System.Drawing.Size(283, 27);
            this.lb_ChooseMode.TabIndex = 12;
            this.lb_ChooseMode.Text = "Choose mode";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pn_Controller);
            this.Controls.Add(this.pn_chooseShipDiff);
            this.Controls.Add(this.pn_leaderBoard);
            this.Controls.Add(this.pn_user);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.btn_login);
            this.DoubleBuffered = true;
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(1582, 1053);
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.pn_user.ResumeLayout(false);
            this.pn_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            this.pn_leaderBoard.ResumeLayout(false);
            this.pn_leaderBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_currentShip)).EndInit();
            this.fpn_chooseShip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_normalShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Emissary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_beholder)).EndInit();
            this.pn_currentShip.ResumeLayout(false);
            this.pn_chooseShipDiff.ResumeLayout(false);
            this.pn_chooseShipDiff.PerformLayout();
            this.pn_chooseShip.ResumeLayout(false);
            this.pn_chooseShip.PerformLayout();
            this.pn_Controller.ResumeLayout(false);
            this.pn_Controller.PerformLayout();
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
        private System.Windows.Forms.Label lb_chooseShip;
        private System.Windows.Forms.PictureBox pb_currentShip;
        private System.Windows.Forms.FlowLayoutPanel fpn_chooseShip;
        private System.Windows.Forms.PictureBox pb_normalShip;
        private System.Windows.Forms.PictureBox pb_Emissary;
        private System.Windows.Forms.PictureBox pb_beholder;
        private System.Windows.Forms.Label lb_setDiff;
        private System.Windows.Forms.Panel pn_currentShip;
        private System.Windows.Forms.Button btn_diff_easy;
        private System.Windows.Forms.Button btn_diff_normal;
        private System.Windows.Forms.Button btn_diff_hard;
        private System.Windows.Forms.Panel pn_chooseShipDiff;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Panel pn_chooseShip;
        private System.Windows.Forms.Panel pn_Controller;
        private System.Windows.Forms.Label lb_ChooseMode;
        private System.Windows.Forms.Button btn_controlMouse;
        private System.Windows.Forms.Button btn_controlKeyboard;
    }
}