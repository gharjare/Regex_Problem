﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Pattern5
    {
        public static string Regex_Upper = "((?=.*[A-Z]).{8,})";
        public bool ValidateUpper(string Upper)
        {
            return Regex.IsMatch(Upper, Regex_Upper);
        }
    }
}

