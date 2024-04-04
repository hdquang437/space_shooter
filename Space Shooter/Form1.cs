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
        static private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(TimerOnTick);
            _timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AudioManager.PlayBGM("bgm1.wav");

        }

        void TimerOnTick(object obj, EventArgs e)
        {
            AudioManager.PlaySE("Laser1.wav");
        }
    }
}
