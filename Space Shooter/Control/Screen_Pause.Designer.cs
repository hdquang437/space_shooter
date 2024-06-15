namespace Space_Shooter.Control
{
    partial class Screen_Pause
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen_Pause));
            this.labelPause = new System.Windows.Forms.Label();
            this.btn_resume = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_backToMenu = new System.Windows.Forms.Button();
            this.pn_Controller = new System.Windows.Forms.Panel();
            this.btn_controlKeyboard = new System.Windows.Forms.Button();
            this.btn_controlMouse = new System.Windows.Forms.Button();
            this.lb_ChooseMode = new System.Windows.Forms.Label();
            this.pn_Controller.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPause
            // 
            this.labelPause.BackColor = System.Drawing.Color.Transparent;
            this.labelPause.Font = new System.Drawing.Font("Algerian", 64F, System.Drawing.FontStyle.Bold);
            this.labelPause.ForeColor = System.Drawing.Color.White;
            this.labelPause.Location = new System.Drawing.Point(0, 50);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(1540, 179);
            this.labelPause.TabIndex = 6;
            this.labelPause.Text = "GAME PAUSE";
            this.labelPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_resume
            // 
            this.btn_resume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_resume.BackColor = System.Drawing.Color.DimGray;
            this.btn_resume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_resume.BackgroundImage")));
            this.btn_resume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_resume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_resume.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resume.ForeColor = System.Drawing.Color.Khaki;
            this.btn_resume.Location = new System.Drawing.Point(618, 265);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(304, 101);
            this.btn_resume.TabIndex = 7;
            this.btn_resume.Text = "resume";
            this.btn_resume.UseVisualStyleBackColor = false;
            this.btn_resume.Click += new System.EventHandler(this.btn_resume_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.BackColor = System.Drawing.Color.DimGray;
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Khaki;
            this.btn_save.Location = new System.Drawing.Point(618, 385);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(304, 101);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_backToMenu
            // 
            this.btn_backToMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_backToMenu.BackColor = System.Drawing.Color.DimGray;
            this.btn_backToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_backToMenu.BackgroundImage")));
            this.btn_backToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_backToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_backToMenu.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backToMenu.ForeColor = System.Drawing.Color.Khaki;
            this.btn_backToMenu.Location = new System.Drawing.Point(618, 505);
            this.btn_backToMenu.Name = "btn_backToMenu";
            this.btn_backToMenu.Size = new System.Drawing.Size(304, 101);
            this.btn_backToMenu.TabIndex = 9;
            this.btn_backToMenu.Text = "back to menu";
            this.btn_backToMenu.UseVisualStyleBackColor = false;
            this.btn_backToMenu.Click += new System.EventHandler(this.btn_backToMenu_Click);
            // 
            // pn_Controller
            // 
            this.pn_Controller.BackColor = System.Drawing.Color.Transparent;
            this.pn_Controller.Controls.Add(this.btn_controlKeyboard);
            this.pn_Controller.Controls.Add(this.btn_controlMouse);
            this.pn_Controller.Controls.Add(this.lb_ChooseMode);
            this.pn_Controller.Location = new System.Drawing.Point(593, 632);
            this.pn_Controller.Name = "pn_Controller";
            this.pn_Controller.Size = new System.Drawing.Size(361, 166);
            this.pn_Controller.TabIndex = 16;
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
            // Screen_Pause
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pn_Controller);
            this.Controls.Add(this.btn_backToMenu);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_resume);
            this.Controls.Add(this.labelPause);
            this.DoubleBuffered = true;
            this.Name = "Screen_Pause";
            this.Size = new System.Drawing.Size(1540, 830);
            this.pn_Controller.ResumeLayout(false);
            this.pn_Controller.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_backToMenu;
        private System.Windows.Forms.Panel pn_Controller;
        private System.Windows.Forms.Button btn_controlKeyboard;
        private System.Windows.Forms.Button btn_controlMouse;
        private System.Windows.Forms.Label lb_ChooseMode;
    }
}
