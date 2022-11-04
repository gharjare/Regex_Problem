using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
    

{
    public class Pattern4
    {
        public static string Regex_Password = "^[A-Za-z0-9]{8}$";
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}
