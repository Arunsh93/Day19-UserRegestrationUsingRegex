using System;

namespace RegexPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Welcome to User Regestration******");
            UserRegestration user = new UserRegestration();
            user.ValidateEmail("abc@yahoo.com");
            user.ValidateEmail("abc-100@yahoo.com");
            user.ValidateEmail("abc.100@yahoo.com");
            user.ValidateEmail("abc111@abc.com");
            user.ValidateEmail("abc-100@abc.net");
            user.ValidateEmail("abc.100@abc.com.au");
            user.ValidateEmail("abc@1.com");
            user.ValidateEmail("abc@gmail.com.com");
            user.ValidateEmail("abc+100@gmail.com");
        }
    }
}
