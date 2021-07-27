using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Join("", username.Reverse());
            int trigger = 0;
            while(trigger != 4)
            {
                trigger++;
                string guessPass = Console.ReadLine();
                if (guessPass == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    if (trigger == 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }
            Console.WriteLine($"User {username} blocked!");
        }
    }
}
