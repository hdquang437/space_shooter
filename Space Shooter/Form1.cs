using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter
{
    public partial class Form1 : Form
    {
        // Screen_Login loginScreen;
        // Screen_SignUp signUpScreen;
        // Screen_Game gameScreen;

        public Form1()
        {
            InitializeComponent();
            Input.GetKeyStates();
            ToCenter();
            AudioManager.PlayBGM(BGM.bgm1);
            // Screen_Login loginScreen = new ...
            // Screen_SignUp signUpScreen = new ...
            // Screen_Game gameScreen = new ...
        }

        public void ToCenter()
        {
            StartPosition = FormStartPosition.Manual;
            Left = (SystemInformation.VirtualScreen.Width - Width) / 2;
            Top = (SystemInformation.VirtualScreen.Height - Height) / 2 - 50;
        }

        public bool IsCenter()
        {
            return Left == (SystemInformation.VirtualScreen.Width - Width) / 2 && Top == (SystemInformation.VirtualScreen.Height - Height) / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_screen.Controls.Add(new Control.Screen_Game(this));
        }

        public void ToGameScreen()
        {
            panel_screen.Controls.Clear();
            //panel_screen.Controls.Add(screenGame);
        }
    }
}
