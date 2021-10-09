using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPracticeProblems
{
    class UserRegestration
    {
        public string RegexEmailId = "^abc.[A-Za-z1-9]*@bl.co.[a-z]*$";

        public bool ValidateEmail(string EmailId)
        {
            return Regex.IsMatch(EmailId, RegexEmailId);
        }
    }
}
