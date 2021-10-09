using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPracticeProblems
{
    class UserRegestration
    {
        public string RegexFirstName = "[A-Z]{1}[a-z]{2}";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, RegexFirstName);
        }
    }
}
