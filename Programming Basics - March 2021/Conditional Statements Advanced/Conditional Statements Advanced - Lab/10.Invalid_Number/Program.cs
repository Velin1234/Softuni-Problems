using System;

namespace _10.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool result = number >= 100 && number <= 200 || number == 0;
            if (!result)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
