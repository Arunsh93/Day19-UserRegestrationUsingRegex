using System;

namespace RegexPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Welcome to User Regestration******");
            UserRegestration user = new UserRegestration();
            Console.Write("Enter Password:Atleast one Uppercase letter: ");
            string userPassword = Console.ReadLine();
            //bool result = user.ValidateEmail(userEmailId);
            //bool result = user.ValidatePhoneNumber(userPhoneNumber);
            bool result = user.ValidatePassword(userPassword);

            if(result == true)
            {
                Console.WriteLine("Valid Password!");
            }
            else
            {
                Console.WriteLine("Invalid Password! Password contain atleast 8 characters.");
            }
        }
    }
}
