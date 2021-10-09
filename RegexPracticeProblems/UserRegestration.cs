using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace RegexPracticeProblems
{
    class UserRegestration
    {
        public string RegexEmailId = "^[A-Za-z0-9]+([-.+][0-9]+)?[0-9]*[@][A-Za-z0-9]+[.][a-zA-Z]{2,}([.][a-z]{2,})?$";


        public void ValidateEmail(string EmailId)
        {
            if (Regex.IsMatch(EmailId, RegexEmailId))
            {
                Console.WriteLine(EmailId + " Valid EmailId!");
            }
            else
            {
                Console.WriteLine(EmailId + " Invalid EmailId!");
            }
        }
    }
}
