using Space_Shooter.AccountManagement.Model;
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
    public partial class Screen_SaveAndLoad : UserControl
    {
        public Mode mode;
        public EventHandler SaveAndLoadButton;
        public EventHandler backButton;

        public int chooseIndex = -1;
        private User currentUser;

        public Screen_SaveAndLoad()
        {
            InitializeComponent();
            saveProfile1.mainClick += new EventHandler(btn_saveProfile_Click);
            saveProfile0.mainClick += new EventHandler(btn_saveProfile_Click);
            saveProfile2.mainClick += new EventHandler(btn_saveProfile_Click);
            saveProfile3.mainClick += new EventHandler(btn_saveProfile_Click);
            saveProfile4.mainClick += new EventHandler(btn_saveProfile_Click);
            saveProfile5.mainClick += new EventHandler(btn_saveProfile_Click);
            saveProfile6.mainClick += new EventHandler(btn_saveProfile_Click);
            saveProfile7.mainClick += new EventHandler(btn_saveProfile_Click);
            saveProfile8.mainClick += new EventHandler(btn_saveProfile_Click);
        }
    
        public void Setup(User user)
        {
            foreach (SaveProfile control in tableLayoutPanel1.Controls)
            {
                control.BackgroundImage = Resources.diff_button_inactive;
            }
            currentUser = user;
            SaveFileManager.Instance.LoadSaveProfilesFromLocal(currentUser);
            btn_SaveAndLoad.Enabled = false;
            UpdateProfiles();

            switch (mode)
            {
                case Mode.Save:
                    btn_SaveAndLoad.Text = "save";
                    break;
                case Mode.Load:
                    btn_SaveAndLoad.Text = "load";
                    break;
            }
        }

        public void UpdateProfiles()
        {
            saveProfile0.Setup(0);
            saveProfile1.Setup(1);
            saveProfile2.Setup(2);
            saveProfile3.Setup(3);
            saveProfile4.Setup(4);
            saveProfile5.Setup(5);
            saveProfile6.Setup(6);
            saveProfile7.Setup(7);
            saveProfile8.Setup(8);
        }

        public enum Mode
        {
            Save,
            Load
        }

        private void btn_saveProfile_Click(object sender, EventArgs e)
        {
            SaveProfile saveProfile = sender as SaveProfile;

            foreach (SaveProfile control in tableLayoutPanel1.Controls)
            {
                control.BackgroundImage = Resources.diff_button_inactive;
            }

            saveProfile.BackgroundImage = Resources.diff_button_active;
            chooseIndex = saveProfile.GetSavefileIndex();

            switch (mode)
            {
                case Mode.Save:
                    btn_SaveAndLoad.Enabled = true;
                    break;
                case Mode.Load:
                    if (SaveFileManager.Instance.saveProfiles[chooseIndex] != null)
                        btn_SaveAndLoad.Enabled = true;
                    else
                        btn_SaveAndLoad.Enabled = false;
                    break;
            }


        }

        private void btn_SaveAndLoad_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.Save:
                    if (SaveFileManager.Instance.saveProfiles[chooseIndex] != null)
                    {   
                        DialogResult dialogResult = MessageBox.Show("Do you want to override this profile?", "Warning", MessageBoxButtons.OKCancel);
                        if (dialogResult == DialogResult.OK)
                        {
                            SaveFileManager.Instance.SaveProfileToLocal(chooseIndex, currentUser);
                            MessageBox.Show($"Save successfully to profile {chooseIndex}!", "Information");
                        }
                    }
                    else
                    {
                        SaveFileManager.Instance.SaveProfileToLocal(chooseIndex, currentUser);
                        MessageBox.Show($"Save successfully to profile {chooseIndex}!", "Information");
                        UpdateProfiles();
                    }
                    break;
                
                case Mode.Load:
                    GameDataManager.LoadSaveProfile(SaveFileManager.Instance.saveProfiles[chooseIndex]);
                    GameDataManager gameDataManager = GameDataManager.Instance;
                    SaveFileManager.Instance.saveProfiles.Clear();
                    SaveFileManager.Instance.LoadSaveProfilesFromLocal(currentUser);
                    SaveAndLoadButton(this, e);
                    break;
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            backButton(this, e);
        }
    }
}
