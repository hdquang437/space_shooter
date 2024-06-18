using Newtonsoft.Json;
using Space_Shooter.AccountManagement.Model;
using Space_Shooter.Control;
using Space_Shooter.Core;
using Space_Shooter.Core.Weapon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Manager
{
    public class SaveFileManager
    {
        static public readonly string SAVE_FOLDER_PATH = $"{Environment.CurrentDirectory}\\save\\";

        private static SaveFileManager instance;

        public static SaveFileManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SaveFileManager();
                    instance.saveProfiles = new List<GameDataManager>() { null, null, null, null, null, null, null, null, null };
                }
                return instance;
            }
        }

        public List<GameDataManager> saveProfiles;

        public void LoadSaveProfilesFromLocal(User user)
        {
            string path = SAVE_FOLDER_PATH + $"savefile_of_user{user.id}.json";
            if (!File.Exists(path))
            {
                FileStream file = File.Create(path);
                file.Close();
            }
            string contents = File.ReadAllText(path);
            instance = JsonConvert.DeserializeObject<SaveFileManager>(contents);
        }

        public void SaveProfileToLocal(int slot, User user)
        {
            saveProfiles[slot] = GameDataManager.Instance;
            saveProfiles[slot].lastPlayTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            
            foreach (Game_Object obj in GameDataManager.Instance.AllCollidableObjects)
            {
                obj.SelfSerializing();
            }

            foreach (List<Game_Enemy> objects in GameDataManager.Instance.stageObjects.Values)
            {
                foreach (Game_Enemy obj in objects)
                {
                    obj.SelfSerializing();
                }
            }

            string json = JsonConvert.SerializeObject(instance);
            File.WriteAllText(SAVE_FOLDER_PATH + $"savefile_of_user{user.id}.json", json);
        }
    }
}
