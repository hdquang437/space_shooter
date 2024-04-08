using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.Control
{
    public partial class ValueBar : ProgressBar
    {
        int dpi;

        public ValueBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // None... Helps control the flicker.
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            const int inset = 2; // A single inset value to control teh sizing of the inner rect.

            using (Image offscreenImage = new Bitmap(this.Width, this.Height))
            {
                float VerRes = offscreenImage.VerticalResolution;
                float HorRes = offscreenImage.HorizontalResolution;
                using (Graphics offscreen = Graphics.FromImage(offscreenImage))
                {
                    Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                    if (ProgressBarRenderer.IsSupported)
                        ProgressBarRenderer.DrawHorizontalBar(offscreen, rect);

                    rect.Inflate(new Size(-inset, -inset)); // Deflate inner rect.
                    rect.Width = (int)(rect.Width * ((double)this.Value / this.Maximum));
                    if (rect.Width > 0) /*rect.Width = 1; // Can't draw rec with width of 0.*/
                    {
                        LinearGradientBrush brush = new LinearGradientBrush(rect, this.BackColor, this.ForeColor, LinearGradientMode.Horizontal);
                        offscreen.FillRectangle(brush, inset, inset, rect.Width, rect.Height);
                    }
                    
                    e.Graphics.ScaleTransform(VerRes / this.DeviceDpi, HorRes / this.DeviceDpi);
                    e.Graphics.DrawImage(offscreenImage, 0, 0);
                }
            }
        }
    }
}
