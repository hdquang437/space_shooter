using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.Control
{
    public partial class Screen_SaveAndLoad : UserControl
    {
        public Screen_Game parentControl;
        public Mode mode;

        public Screen_SaveAndLoad()
        {
            InitializeComponent();
        }
    
        public void Setup()
        {
            switch (mode)
            {
                case Mode.Save:
                
                    break;
                case Mode.Load:
                    
                    break;
            }
        }

        public enum Mode
        {
            Save,
            Load
        }
    }
}
