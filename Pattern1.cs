using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Pattern1

    {
        public static string Regex_LastName = "^[A-z]{1}[a-z]{2,10}$";

        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, Regex_LastName);
        }
    }
}
