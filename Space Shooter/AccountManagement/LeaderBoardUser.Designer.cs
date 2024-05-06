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
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userName.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_userName.Location = new System.Drawing.Point(110, 29);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(156, 18);
            this.lb_userName.TabIndex = 1;
            this.lb_userName.Text = "User Name";
            // 
            // lb_highestScoreValue
            // 
            this.lb_highestScoreValue.AutoSize = true;
            this.lb_highestScoreValue.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_highestScoreValue.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lb_highestScoreValue.Location = new System.Drawing.Point(108, 74);
            this.lb_highestScoreValue.Name = "lb_highestScoreValue";
            this.lb_highestScoreValue.Size = new System.Drawing.Size(68, 18);
            this.lb_highestScoreValue.TabIndex = 2;
            this.lb_highestScoreValue.Text = "10000";
            // 
            // lb_highestscore
            // 
            this.lb_highestscore.AutoSize = true;
            this.lb_highestscore.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_highestscore.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lb_highestscore.Location = new System.Drawing.Point(110, 54);
            this.lb_highestscore.Name = "lb_highestscore";
            this.lb_highestscore.Size = new System.Drawing.Size(94, 18);
            this.lb_highestscore.TabIndex = 3;
            this.lb_highestscore.Text = "Score:";
            // 
            // pb_avatar
            // 
            this.pb_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pb_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_avatar.Location = new System.Drawing.Point(19, 19);
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.Size = new System.Drawing.Size(86, 77);
            this.pb_avatar.TabIndex = 0;
            this.pb_avatar.TabStop = false;
            // 
            // LeaderBoardUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lb_highestScoreValue);
            this.Controls.Add(this.lb_highestscore);
            this.Controls.Add(this.lb_userName);
            this.Controls.Add(this.pb_avatar);
            this.Name = "LeaderBoardUser";
            this.Size = new System.Drawing.Size(300, 113);
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_avatar;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label lb_highestScoreValue;
        private System.Windows.Forms.Label lb_highestscore;
    }
}
