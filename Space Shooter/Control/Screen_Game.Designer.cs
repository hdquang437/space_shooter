namespace Space_Shooter.Control
{
    partial class Screen_Game
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
            this.valueBar_HP = new Space_Shooter.Control.ValueBar();
            this.valueBar_Ammo = new Space_Shooter.Control.ValueBar();
            this.label_HP = new System.Windows.Forms.Label();
            this.label_Ammo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valueBar_HP
            // 
            this.valueBar_HP.BackColor = System.Drawing.Color.MediumAquamarine;
            this.valueBar_HP.ForeColor = System.Drawing.Color.Lime;
            this.valueBar_HP.Location = new System.Drawing.Point(32, 33);
            this.valueBar_HP.Name = "valueBar_HP";
            this.valueBar_HP.Size = new System.Drawing.Size(250, 24);
            this.valueBar_HP.TabIndex = 0;
            this.valueBar_HP.Value = 100;
            // 
            // valueBar_Ammo
            // 
            this.valueBar_Ammo.BackColor = System.Drawing.Color.Brown;
            this.valueBar_Ammo.ForeColor = System.Drawing.Color.Red;
            this.valueBar_Ammo.Location = new System.Drawing.Point(32, 86);
            this.valueBar_Ammo.Name = "valueBar_Ammo";
            this.valueBar_Ammo.Size = new System.Drawing.Size(200, 24);
            this.valueBar_Ammo.TabIndex = 1;
            this.valueBar_Ammo.Value = 100;
            // 
            // label_HP
            // 
            this.label_HP.AutoSize = true;
            this.label_HP.BackColor = System.Drawing.Color.Transparent;
            this.label_HP.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HP.ForeColor = System.Drawing.Color.White;
            this.label_HP.Location = new System.Drawing.Point(29, 14);
            this.label_HP.Name = "label_HP";
            this.label_HP.Size = new System.Drawing.Size(80, 19);
            this.label_HP.TabIndex = 2;
            this.label_HP.Text = "health";
            // 
            // label_Ammo
            // 
            this.label_Ammo.AutoSize = true;
            this.label_Ammo.BackColor = System.Drawing.Color.Transparent;
            this.label_Ammo.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ammo.ForeColor = System.Drawing.Color.White;
            this.label_Ammo.Location = new System.Drawing.Point(29, 64);
            this.label_Ammo.Name = "label_Ammo";
            this.label_Ammo.Size = new System.Drawing.Size(61, 19);
            this.label_Ammo.TabIndex = 3;
            this.label_Ammo.Text = "ammo";
            // 
            // Screen_Game
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label_Ammo);
            this.Controls.Add(this.label_HP);
            this.Controls.Add(this.valueBar_Ammo);
            this.Controls.Add(this.valueBar_HP);
            this.DoubleBuffered = true;
            this.Name = "Screen_Game";
            this.Size = new System.Drawing.Size(1600, 1080);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Screen_Game_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ValueBar valueBar_HP;
        private ValueBar valueBar_Ammo;
        private System.Windows.Forms.Label label_HP;
        private System.Windows.Forms.Label label_Ammo;
    }
}
