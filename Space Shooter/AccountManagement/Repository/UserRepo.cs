using Newtonsoft.Json;
using Space_Shooter.AccountManagement.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.AccountManagement.Repository
{
    public class UserRepo
    {
        public static string filePath = FilePathManager.GetFilePath("users");

        public static void SaveToFile(List<User> users, string filePath)
        {
            string json = JsonConvert.SerializeObject(users);
            File.WriteAllText(filePath, json);
        }


        public static User AddUser(string fullName, string password, string email, string avaPath, int highestScore)
        {
            List<User> users = LoadUsersFromFile();
            User user = new User(fullName, password, email, "", highestScore);
            user.id = users.Count();
            user.avaPath = user.id + Path.GetExtension(avaPath);
            users.Add(user);
            SaveToFile(users, filePath);
            return user;
        }

        public static List<User> LoadUsersFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
                return users == null ? new List<User>() : users;
            }
            return new List<User>();
        }

        public static bool IsUserExists(string email, string password)
        {
            List<User> users = LoadUsersFromFile();
            return users.Any(u => u.email == email && u.password == password);
        }

        public static User Login(string email, string password)
        {
            List<User> users = LoadUsersFromFile();
            return users.FirstOrDefault(u => u.email == email && u.password == password);
        }

        public static bool IsEmailExists(string email)
        {
            List<User> users = LoadUsersFromFile();
            return users.Any(u => u.email == email);
        }

        public static User GetUserByEmail(string email)
        {
            List<User> users = LoadUsersFromFile();
            return users.FirstOrDefault(u => u.email == email);
        }
        public static void UpdatePassword(string email, string newPassword)
        {
            List<User> users = LoadUsersFromFile();
            User user = users.FirstOrDefault(u => u.email == email);
            if (user != null)
            {
                user.password = newPassword;
                SaveToFile(users, filePath);
            }
            else
            {
                MessageBox.Show("This account does not exist!");
            }
        }
    }
}
