namespace Space_Shooter.AccountManagement
{
    partial class LeaderBoardUser
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
            this.lb_userName = new System.Windows.Forms.Label();
            this.lb_highestScoreValue = new System.Windows.Forms.Label();
            this.lb_highestscore = new System.Windows.Forms.Label();
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            this.lb_PlayTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_userName
            // 
            this.lb_userName.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userName.ForeColor = System.Drawing.Color.SpringGreen;
            this.lb_userName.Location = new System.Drawing.Point(91, 11);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(205, 22);
            this.lb_userName.TabIndex = 1;
            this.lb_userName.Text = "Lê Ngọc Hưng";
            this.lb_userName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_highestScoreValue
            // 
            this.lb_highestScoreValue.AutoSize = true;
            this.lb_highestScoreValue.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_highestScoreValue.ForeColor = System.Drawing.Color.Gold;
            this.lb_highestScoreValue.Location = new System.Drawing.Point(236, 39);
            this.lb_highestScoreValue.Name = "lb_highestScoreValue";
            this.lb_highestScoreValue.Size = new System.Drawing.Size(68, 18);
            this.lb_highestScoreValue.TabIndex = 2;
            this.lb_highestScoreValue.Text = "10000";
            // 
            // lb_highestscore
            // 
            this.lb_highestscore.AutoSize = true;
            this.lb_highestscore.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_highestscore.ForeColor = System.Drawing.Color.Gold;
            this.lb_highestscore.Location = new System.Drawing.Point(91, 39);
            this.lb_highestscore.Name = "lb_highestscore";
            this.lb_highestscore.Size = new System.Drawing.Size(94, 18);
            this.lb_highestscore.TabIndex = 3;
            this.lb_highestscore.Text = "Score:";
            // 
            // pb_avatar
            // 
            this.pb_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pb_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_avatar.Location = new System.Drawing.Point(13, 9);
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.Size = new System.Drawing.Size(59, 53);
            this.pb_avatar.TabIndex = 0;
            this.pb_avatar.TabStop = false;
            // 
            // lb_PlayTime
            // 
            this.lb_PlayTime.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PlayTime.ForeColor = System.Drawing.Color.FloralWhite;
            this.lb_PlayTime.Location = new System.Drawing.Point(265, 15);
            this.lb_PlayTime.Name = "lb_PlayTime";
            this.lb_PlayTime.Size = new System.Drawing.Size(97, 18);
            this.lb_PlayTime.TabIndex = 4;
            this.lb_PlayTime.Text = "--:--:--";
            this.lb_PlayTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LeaderBoardUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lb_PlayTime);
            this.Controls.Add(this.lb_highestScoreValue);
            this.Controls.Add(this.lb_highestscore);
            this.Controls.Add(this.lb_userName);
            this.Controls.Add(this.pb_avatar);
            this.Name = "LeaderBoardUser";
            this.Size = new System.Drawing.Size(390, 70);
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_avatar;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label lb_highestScoreValue;
        private System.Windows.Forms.Label lb_highestscore;
        private System.Windows.Forms.Label lb_PlayTime;
    }
}
