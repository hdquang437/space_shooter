namespace Space_Shooter.Control
{
    partial class InstructionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionScreen));
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.btn_next_top = new System.Windows.Forms.PictureBox();
            this.btn_pre_top = new System.Windows.Forms.PictureBox();
            this.btn_pre_bot = new System.Windows.Forms.PictureBox();
            this.btn_next_bot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pre_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pre_bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next_bot)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_exit
            // 
            this.pb_exit.BackColor = System.Drawing.Color.Transparent;
            this.pb_exit.Image = ((System.Drawing.Image)(resources.GetObject("pb_exit.Image")));
            this.pb_exit.Location = new System.Drawing.Point(33, 30);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(55, 50);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_exit.TabIndex = 12;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // btn_next_top
            // 
            this.btn_next_top.BackColor = System.Drawing.Color.Transparent;
            this.btn_next_top.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_next_top.Image = ((System.Drawing.Image)(resources.GetObject("btn_next_top.Image")));
            this.btn_next_top.Location = new System.Drawing.Point(1034, 66);
            this.btn_next_top.Name = "btn_next_top";
            this.btn_next_top.Size = new System.Drawing.Size(55, 50);
            this.btn_next_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_next_top.TabIndex = 12;
            this.btn_next_top.TabStop = false;
            this.btn_next_top.Click += new System.EventHandler(this.btn_next_top_Click);
            // 
            // btn_pre_top
            // 
            this.btn_pre_top.BackColor = System.Drawing.Color.Transparent;
            this.btn_pre_top.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_pre_top.Image = ((System.Drawing.Image)(resources.GetObject("btn_pre_top.Image")));
            this.btn_pre_top.Location = new System.Drawing.Point(445, 66);
            this.btn_pre_top.Name = "btn_pre_top";
            this.btn_pre_top.Size = new System.Drawing.Size(55, 50);
            this.btn_pre_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_pre_top.TabIndex = 12;
            this.btn_pre_top.TabStop = false;
            this.btn_pre_top.Visible = false;
            this.btn_pre_top.Click += new System.EventHandler(this.btn_pre_top_Click);
            // 
            // btn_pre_bot
            // 
            this.btn_pre_bot.BackColor = System.Drawing.Color.Transparent;
            this.btn_pre_bot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_pre_bot.Image = ((System.Drawing.Image)(resources.GetObject("btn_pre_bot.Image")));
            this.btn_pre_bot.Location = new System.Drawing.Point(50, 394);
            this.btn_pre_bot.Name = "btn_pre_bot";
            this.btn_pre_bot.Size = new System.Drawing.Size(55, 50);
            this.btn_pre_bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_pre_bot.TabIndex = 12;
            this.btn_pre_bot.TabStop = false;
            this.btn_pre_bot.Visible = false;
            this.btn_pre_bot.Click += new System.EventHandler(this.btn_pre_bot_Click);
            // 
            // btn_next_bot
            // 
            this.btn_next_bot.BackColor = System.Drawing.Color.Transparent;
            this.btn_next_bot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_next_bot.Image = ((System.Drawing.Image)(resources.GetObject("btn_next_bot.Image")));
            this.btn_next_bot.Location = new System.Drawing.Point(1435, 394);
            this.btn_next_bot.Name = "btn_next_bot";
            this.btn_next_bot.Size = new System.Drawing.Size(55, 50);
            this.btn_next_bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_next_bot.TabIndex = 12;
            this.btn_next_bot.TabStop = false;
            this.btn_next_bot.Visible = false;
            this.btn_next_bot.Click += new System.EventHandler(this.btn_next_bot_Click);
            // 
            // InstructionScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_pre_bot);
            this.Controls.Add(this.btn_pre_top);
            this.Controls.Add(this.btn_next_bot);
            this.Controls.Add(this.btn_next_top);
            this.Controls.Add(this.pb_exit);
            this.Name = "InstructionScreen";
            this.Size = new System.Drawing.Size(1540, 838);
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pre_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pre_bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next_bot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.PictureBox btn_next_top;
        private System.Windows.Forms.PictureBox btn_pre_top;
        private System.Windows.Forms.PictureBox btn_pre_bot;
        private System.Windows.Forms.PictureBox btn_next_bot;
    }
}
