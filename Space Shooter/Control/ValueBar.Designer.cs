using System.Drawing;
using System.Windows.Forms;

namespace Space_Shooter.Control
{
    partial class ValueBar : ProgressBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //private SizeF AutoScaleDimensions { get; private set; }
        //private AutoScaleMode AutoScaleMode { get; set; }

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
            this.SuspendLayout();
            // 
            // ValueBar
            // 
            this.Size = new System.Drawing.Size(200, 30);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
