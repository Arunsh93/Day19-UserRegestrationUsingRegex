using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPracticeProblems
{
    class UserRegestration
    {
        public string RegexLastName = "^[A-Za-z]{1}[a-z]{2}";
        public bool ValidateFirstName(string LastName)
        {
            return Regex.IsMatch(LastName, RegexLastName);
        }
    }
}
