using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            while (true)
            {
                number = Math.Abs(number);
                if (number % 2 ==0)
                {
                    break;
                }
                Console.WriteLine("Please write an even number.");
                number= int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {number}");
        }
    }
}
