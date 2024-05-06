using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AccountManagement.Repository.FilePathManager.AddFilePath("users", $"{Environment.CurrentDirectory}\\data\\users.json");
            AccountManagement.Repository.FilePathManager.AddFilePath("images", $"{Environment.CurrentDirectory}\\Images\\");
            Application.Run(new AccountManagement.HomeScreen());
        }
    }
}
