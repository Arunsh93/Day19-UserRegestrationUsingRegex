using System;

namespace RegexPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Welcome to User Regestration******");
            UserRegestration user = new UserRegestration();
            Console.Write("Enter Email: ");
            string userEmailId = Console.ReadLine();
            bool result = user.ValidateEmail(userEmailId);

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
