using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int trigger = 0;
            if (number % 2 == 0)
            {
                trigger = 2;
            }
            if (number % 3 == 0)
            {
                trigger = 3;
            }
            if (number % 6 == 0)
            {
                trigger = 6;
            }
            if (number % 7 == 0)
            {
                trigger = 7;
            }
            if (number % 10 == 0)
            {
                trigger = 10;
            }

            if (trigger != 0)
            {
                Console.WriteLine($"The number is divisible by {trigger}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
