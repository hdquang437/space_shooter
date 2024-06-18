using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.Control
{
    public partial class SaveProfile : UserControl
    {
        public EventHandler mainClick;

        public SaveProfile()
        {
            InitializeComponent();
            lb_Index.Click += new EventHandler(ClickEvent);
            lb_difficulty.Click += new EventHandler(ClickEvent);
            lb_playtime.Click += new EventHandler(ClickEvent);
            lb_savefileName.Click += new EventHandler(ClickEvent);
            lb_stage.Click += new EventHandler(ClickEvent);
            Click += new EventHandler(ClickEvent);
        }

        public void SetClickEventHandler()
        {
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            mainClick(this, e);
        }

        public void Setup(int index)
        {
            GameDataManager gameDataManager = SaveFileManager.Instance.saveProfiles[index];

            if (gameDataManager == null)
            {
                lb_Index.Text = index.ToString();
                lb_difficulty.Text = "difficulty: --";
                lb_playtime.Text = "play time: --:--:--";
                lb_savefileName.Text = "empty savefile";
                lb_stage.Text = "stage: -";
                return;
            }

            lb_Index.Text = index.ToString();
            lb_difficulty.Text = "difficulty: " + gameDataManager.GetDifficultyStr;
            lb_playtime.Text = "play time: " + gameDataManager.PlayTimeStr;
            lb_savefileName.Text = "savefile: " + gameDataManager.lastPlayTime;
            lb_stage.Text = "stage: " + gameDataManager.Stage;
        }

        public int GetSavefileIndex()
        {
            return Convert.ToInt32(lb_Index.Text);
        }
    }
}
