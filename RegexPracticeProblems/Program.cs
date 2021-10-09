using System;

namespace RegexPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Welcome to User Regestration******");
            UserRegestration user = new UserRegestration();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            bool result = user.ValidateFirstName(lastName);

            if(result == true)
            {
                Console.WriteLine("Valid Name!");
            }
            else
            {
                Console.WriteLine("Invalid Name!");
            }
        }
    }
}
