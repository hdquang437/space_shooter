using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Space_Shooter.AccountManagement.Repository
{
    public class InputValidator
    {
        static public bool validateEmail(string mail)
        {
            var trimmedEmail = mail.ToString().Trim();
            string pattern = @"^[a-zA-Z0-9.+]+@gmail\.com$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(trimmedEmail);
            return match.Success;
        }

        public static bool validatePassword(string password)
        {
            if (password != null && password != "")
            {
                return true;
            }
            else { return false; }
        }
        public static bool validateName(string name)
        {
            if (name != null && name != "")
            {
                return true;
            }
            else { return false; }
        }
    }
}
