using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Media.Media3D;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Space_Shooter.Manager
{
    internal class AudioManager
    {
        // Audio
        //static private SoundPlayer bgm;
        [DllImport("winmm.dll")]
        static private extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);
        static private int _alias = 0;
        static private SoundPlayer bgm;

        private const int MAX_SE_PER_PERIOD = 5;
        static private int played_se_count = 0;
        static private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        static public void PlayBGM(string file)
        {
            string link = @"audio\bgm\" + file;
            bgm = new SoundPlayer(link);
            bgm.PlayLooping();
        }

        static public void PlaySE(string file)
        {
            if (file == SE.None)
            {
                return;
            }
            var t = new Thread(() => ThreadPlaySE(file));
            t.Start();
        }

        static private void ThreadPlaySE(string file)
        {
            if (played_se_count < MAX_SE_PER_PERIOD)
            {
                played_se_count++;
            }
            else
            {
                return;
            }

            string link = @"audio\se\" + file;
            string alias = @"sound" + _alias;
            mciSendString(@"close " + alias, null, 0, IntPtr.Zero);
            mciSendString(@"open " + link + " type waveaudio alias " + alias, null, 0, IntPtr.Zero);
            mciSendString(@"play " + alias, null, 0, IntPtr.Zero);
            //mciSendString(@"setaudio " + alias + " volume to 1000", null, 0, IntPtr.Zero);
            if (_alias < 10)
            {
                _alias++;
            }
            else
            {
                _alias = 0;
            }
        }

        static public void InitializeController()
        {
            _timer.Interval = 20;
            _timer.Tick += new EventHandler(TimerOnTick);
            _timer.Start();
        }

        static private void TimerOnTick(object obj, EventArgs e)
        {
            played_se_count = 0;
        }
    }
}
