using System;

namespace _05.Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password_guess = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";
            if (password_guess == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
