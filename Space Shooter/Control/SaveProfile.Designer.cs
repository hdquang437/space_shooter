namespace Space_Shooter.Control
{
    partial class SaveProfile
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
            this.lb_Index = new System.Windows.Forms.Label();
            this.lb_savefileName = new System.Windows.Forms.Label();
            this.lb_playtime = new System.Windows.Forms.Label();
            this.lb_stage = new System.Windows.Forms.Label();
            this.lb_difficulty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Index
            // 
            this.lb_Index.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Index.ForeColor = System.Drawing.Color.White;
            this.lb_Index.Location = new System.Drawing.Point(15, 14);
            this.lb_Index.Name = "lb_Index";
            this.lb_Index.Size = new System.Drawing.Size(96, 96);
            this.lb_Index.TabIndex = 0;
            this.lb_Index.Text = "0";
            this.lb_Index.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_savefileName
            // 
            this.lb_savefileName.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_savefileName.ForeColor = System.Drawing.Color.White;
            this.lb_savefileName.Location = new System.Drawing.Point(110, 10);
            this.lb_savefileName.Name = "lb_savefileName";
            this.lb_savefileName.Size = new System.Drawing.Size(340, 53);
            this.lb_savefileName.TabIndex = 1;
            this.lb_savefileName.Text = "savefile: dd/MM/yyyy HH:mm:ss";
            this.lb_savefileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_playtime
            // 
            this.lb_playtime.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_playtime.ForeColor = System.Drawing.Color.White;
            this.lb_playtime.Location = new System.Drawing.Point(123, 54);
            this.lb_playtime.Name = "lb_playtime";
            this.lb_playtime.Size = new System.Drawing.Size(296, 25);
            this.lb_playtime.TabIndex = 2;
            this.lb_playtime.Text = "play time: --:--:--";
            this.lb_playtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_stage
            // 
            this.lb_stage.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stage.ForeColor = System.Drawing.Color.White;
            this.lb_stage.Location = new System.Drawing.Point(302, 79);
            this.lb_stage.Name = "lb_stage";
            this.lb_stage.Size = new System.Drawing.Size(117, 27);
            this.lb_stage.TabIndex = 3;
            this.lb_stage.Text = "stage: 1";
            this.lb_stage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_difficulty
            // 
            this.lb_difficulty.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_difficulty.ForeColor = System.Drawing.Color.White;
            this.lb_difficulty.Location = new System.Drawing.Point(122, 78);
            this.lb_difficulty.Name = "lb_difficulty";
            this.lb_difficulty.Size = new System.Drawing.Size(173, 27);
            this.lb_difficulty.TabIndex = 4;
            this.lb_difficulty.Text = "difficulty: medium";
            this.lb_difficulty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Space_Shooter.Properties.Resources.diff_button_active;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lb_difficulty);
            this.Controls.Add(this.lb_stage);
            this.Controls.Add(this.lb_playtime);
            this.Controls.Add(this.lb_savefileName);
            this.Controls.Add(this.lb_Index);
            this.DoubleBuffered = true;
            this.Name = "SaveProfile";
            this.Size = new System.Drawing.Size(442, 129);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Index;
        private System.Windows.Forms.Label lb_savefileName;
        private System.Windows.Forms.Label lb_playtime;
        private System.Windows.Forms.Label lb_stage;
        private System.Windows.Forms.Label lb_difficulty;
    }
}
