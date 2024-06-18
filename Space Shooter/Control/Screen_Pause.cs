using Space_Shooter.Manager;
using Space_Shooter.Properties;
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
    public partial class Screen_Pause : UserControl
    {
        public Screen_Game parentControl;

        public Screen_Pause()
        {
            InitializeComponent();
        }

        private void btn_resume_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GameDataManager.Instance.isPaused = false;
        }

        private void btn_backToMenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GameDataManager.Instance.isPaused = false;
            parentControl.BackToMenu();
        }

        private void btn_controlMouse_Click(object sender, EventArgs e)
        {
            if (GameDataManager.Instance.playMode == PlayMode.Mouse)
                return;
            GameDataManager.Instance.playMode = PlayMode.Mouse;
            btn_controlMouse.BackgroundImage = Resources.controller_mouse_active;
            btn_controlKeyboard.BackgroundImage = Resources.controller_keyboard_deactive;
        }

        private void btn_controlKeyboard_Click(object sender, EventArgs e)
        {
            if (GameDataManager.Instance.playMode == PlayMode.Keyboard)
                return;
            GameDataManager.Instance.playMode = PlayMode.Keyboard;
            btn_controlMouse.BackgroundImage = Resources.controller_mouse_deactive;
            btn_controlKeyboard.BackgroundImage = Resources.controller_keyboard_active;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            parentControl.OpenSave();
        }
    }
}
