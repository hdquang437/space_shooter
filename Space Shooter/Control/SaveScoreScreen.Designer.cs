namespace Space_Shooter.Control
{
    partial class SaveScoreScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveScoreScreen));
            this.pn_user = new System.Windows.Forms.Panel();
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            this.lb_userName = new System.Windows.Forms.Label();
            this.pb_victory = new System.Windows.Forms.PictureBox();
            this.pn_result = new System.Windows.Forms.Panel();
            this.lb_playtime = new System.Windows.Forms.Label();
            this.lb_senceten = new System.Windows.Forms.Label();
            this.lb_yourScore = new System.Windows.Forms.Label();
            this.lb_scoreVal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
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
            this.pn_user.Location = new System.Drawing.Point(3, 3);
            this.pn_user.Name = "pn_user";
            this.pn_user.Size = new System.Drawing.Size(504, 254);
            this.pn_user.TabIndex = 8;
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
            // pb_victory
            // 
            this.pb_victory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_victory.BackColor = System.Drawing.Color.Transparent;
            this.pb_victory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_victory.Image = ((System.Drawing.Image)(resources.GetObject("pb_victory.Image")));
            this.pb_victory.Location = new System.Drawing.Point(493, 28);
            this.pb_victory.Name = "pb_victory";
            this.pb_victory.Size = new System.Drawing.Size(539, 206);
            this.pb_victory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_victory.TabIndex = 7;
            this.pb_victory.TabStop = false;
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
            this.pn_result.Location = new System.Drawing.Point(361, 263);
            this.pn_result.Name = "pn_result";
            this.pn_result.Size = new System.Drawing.Size(818, 334);
            this.pn_result.TabIndex = 12;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(21, 616);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(232, 677);
            this.richTextBox1.MaxLength = 200;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(1107, 148);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back.Location = new System.Drawing.Point(1391, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(56, 51);
            this.btn_back.TabIndex = 14;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save.Location = new System.Drawing.Point(1468, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 51);
            this.btn_save.TabIndex = 14;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // SaveScoreScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pn_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_victory);
            this.Controls.Add(this.pn_result);
            this.Name = "SaveScoreScreen";
            this.Size = new System.Drawing.Size(1540, 838);
            this.Load += new System.EventHandler(this.SaveScoreScreen_Load);
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
        private System.Windows.Forms.Label lb_senceten;
        private System.Windows.Forms.Label lb_yourScore;
        private System.Windows.Forms.Label lb_scoreVal;
        private System.Windows.Forms.PictureBox pb_victory;
        private System.Windows.Forms.Label lb_playtime;
        private System.Windows.Forms.Panel pn_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_save;
    }
}
