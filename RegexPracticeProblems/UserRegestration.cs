using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPracticeProblems
{
    class UserRegestration
    {
        public string RegexEmailId = "^abc.[A-Za-z1-9]*@bl.co.[a-z]*$";
        public string RegexPhoneNumber = "^[0-9]{2}[ ][0-9]{10}$";

        public bool ValidateEmail(string EmailId)
        {
            return Regex.IsMatch(EmailId, RegexEmailId);
        }

        public bool ValidatePhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, RegexPhoneNumber);
        }
    }
}
