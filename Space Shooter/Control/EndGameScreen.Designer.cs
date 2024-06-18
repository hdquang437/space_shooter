namespace Space_Shooter.Control
{
    partial class EndGameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGameScreen));
            this.pn_user = new System.Windows.Forms.Panel();
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            this.lb_userName = new System.Windows.Forms.Label();
            this.lb_senceten = new System.Windows.Forms.Label();
            this.lb_scoreVal = new System.Windows.Forms.Label();
            this.lb_yourScore = new System.Windows.Forms.Label();
            this.btn_mainmenu = new System.Windows.Forms.Button();
            this.pb_victory = new System.Windows.Forms.PictureBox();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_share = new System.Windows.Forms.Button();
            this.lb_playtime = new System.Windows.Forms.Label();
            this.pn_result = new System.Windows.Forms.Panel();
            this.pn_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_victory)).BeginInit();
            this.pn_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_user
            // 
            this.pn_user.BackColor = System.Drawing.Color.Transparent;
            this.pn_user.Controls.Add(this.pb_avatar);
            this.pn_user.Controls.Add(this.lb_userName);
            this.pn_user.Location = new System.Drawing.Point(59, 16);
            this.pn_user.Name = "pn_user";
            this.pn_user.Size = new System.Drawing.Size(562, 332);
            this.pn_user.TabIndex = 3;
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
            // lb_senceten
            // 
            this.lb_senceten.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_senceten.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senceten.ForeColor = System.Drawing.Color.Gold;
            this.lb_senceten.Location = new System.Drawing.Point(83, 30);
            this.lb_senceten.MaximumSize = new System.Drawing.Size(1000, 90);
            this.lb_senceten.Name = "lb_senceten";
            this.lb_senceten.Size = new System.Drawing.Size(660, 90);
            this.lb_senceten.TabIndex = 0;
            this.lb_senceten.Text = "Too bad! Better luck next time!";
            this.lb_senceten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_scoreVal
            // 
            this.lb_scoreVal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_scoreVal.BackColor = System.Drawing.Color.Transparent;
            this.lb_scoreVal.Font = new System.Drawing.Font("Goudy Stout", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_scoreVal.ForeColor = System.Drawing.Color.Gold;
            this.lb_scoreVal.Location = new System.Drawing.Point(0, 171);
            this.lb_scoreVal.Name = "lb_scoreVal";
            this.lb_scoreVal.Size = new System.Drawing.Size(818, 51);
            this.lb_scoreVal.TabIndex = 0;
            this.lb_scoreVal.Text = "10000";
            this.lb_scoreVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_yourScore
            // 
            this.lb_yourScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_yourScore.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_yourScore.ForeColor = System.Drawing.Color.Lime;
            this.lb_yourScore.Location = new System.Drawing.Point(2, 120);
            this.lb_yourScore.Name = "lb_yourScore";
            this.lb_yourScore.Size = new System.Drawing.Size(815, 41);
            this.lb_yourScore.TabIndex = 0;
            this.lb_yourScore.Text = "Your Score";
            this.lb_yourScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_mainmenu
            // 
            this.btn_mainmenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_mainmenu.BackColor = System.Drawing.Color.DimGray;
            this.btn_mainmenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_mainmenu.BackgroundImage")));
            this.btn_mainmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mainmenu.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainmenu.ForeColor = System.Drawing.Color.Khaki;
            this.btn_mainmenu.Location = new System.Drawing.Point(506, 666);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new System.Drawing.Size(304, 101);
            this.btn_mainmenu.TabIndex = 4;
            this.btn_mainmenu.Text = "Main Menu";
            this.btn_mainmenu.UseVisualStyleBackColor = false;
            this.btn_mainmenu.Click += new System.EventHandler(this.btn_mainmenu_Click);
            // 
            // pb_victory
            // 
            this.pb_victory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_victory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_victory.Image = ((System.Drawing.Image)(resources.GetObject("pb_victory.Image")));
            this.pb_victory.Location = new System.Drawing.Point(555, 83);
            this.pb_victory.Name = "pb_victory";
            this.pb_victory.Size = new System.Drawing.Size(539, 206);
            this.pb_victory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_victory.TabIndex = 2;
            this.pb_victory.TabStop = false;
            // 
            // btn_continue
            // 
            this.btn_continue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_continue.BackColor = System.Drawing.Color.DimGray;
            this.btn_continue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_continue.BackgroundImage")));
            this.btn_continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_continue.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.ForeColor = System.Drawing.Color.Khaki;
            this.btn_continue.Location = new System.Drawing.Point(836, 666);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(304, 101);
            this.btn_continue.TabIndex = 4;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_share
            // 
            this.btn_share.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_share.BackColor = System.Drawing.Color.DimGray;
            this.btn_share.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_share.BackgroundImage")));
            this.btn_share.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_share.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_share.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_share.ForeColor = System.Drawing.Color.Khaki;
            this.btn_share.Location = new System.Drawing.Point(557, 803);
            this.btn_share.Name = "btn_share";
            this.btn_share.Size = new System.Drawing.Size(537, 101);
            this.btn_share.TabIndex = 4;
            this.btn_share.Text = "Save Your Score";
            this.btn_share.UseVisualStyleBackColor = false;
            this.btn_share.Click += new System.EventHandler(this.btn_share_Click);
            // 
            // lb_playtime
            // 
            this.lb_playtime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_playtime.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_playtime.ForeColor = System.Drawing.Color.White;
            this.lb_playtime.Location = new System.Drawing.Point(0, 239);
            this.lb_playtime.Name = "lb_playtime";
            this.lb_playtime.Size = new System.Drawing.Size(815, 41);
            this.lb_playtime.TabIndex = 5;
            this.lb_playtime.Text = "Play time: --:--:--";
            this.lb_playtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_result
            // 
            this.pn_result.BackColor = System.Drawing.Color.Transparent;
            this.pn_result.BackgroundImage = global::Space_Shooter.Properties.Resources.ship_border;
            this.pn_result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_result.Controls.Add(this.lb_playtime);
            this.pn_result.Controls.Add(this.lb_senceten);
            this.pn_result.Controls.Add(this.lb_yourScore);
            this.pn_result.Controls.Add(this.lb_scoreVal);
            this.pn_result.Location = new System.Drawing.Point(650, 295);
            this.pn_result.Name = "pn_result";
            this.pn_result.Size = new System.Drawing.Size(818, 334);
            this.pn_result.TabIndex = 6;
            // 
            // EndGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_share);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_mainmenu);
            this.Controls.Add(this.pb_victory);
            this.Controls.Add(this.pn_result);
            this.Controls.Add(this.pn_user);
            this.DoubleBuffered = true;
            this.Name = "EndGameScreen";
            this.Size = new System.Drawing.Size(1582, 1053);
            this.Load += new System.EventHandler(this.EndGameScreen_Load);
            this.pn_user.ResumeLayout(false);
            this.pn_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_victory)).EndInit();
            this.pn_result.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_user;
        private System.Windows.Forms.PictureBox pb_avatar;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.PictureBox pb_victory;
        private System.Windows.Forms.Label lb_senceten;
        private System.Windows.Forms.Label lb_scoreVal;
        private System.Windows.Forms.Label lb_yourScore;
        private System.Windows.Forms.Button btn_mainmenu;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Button btn_share;
        private System.Windows.Forms.Label lb_playtime;
        private System.Windows.Forms.Panel pn_result;
    }
}
