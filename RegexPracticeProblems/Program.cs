using System;

namespace RegexPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Welcome to User Regestration******");
            UserRegestration user = new UserRegestration();
            Console.Write("Enter Phone Number: ");
            string userPhoneNumber = Console.ReadLine();
            //bool result = user.ValidateEmail(userEmailId);
            bool result = user.ValidatePhoneNumber(userPhoneNumber);

            if(result == true)
            {
                Console.WriteLine("Valid EmailId!");
            }
            else
            {
                Console.WriteLine("Invalid EmailId!");
            }
        }
    }
}
