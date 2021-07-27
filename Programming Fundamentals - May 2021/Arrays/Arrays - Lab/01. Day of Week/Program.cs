using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]days = {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
            int day = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(days[day - 1]);

            }
            catch 
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
