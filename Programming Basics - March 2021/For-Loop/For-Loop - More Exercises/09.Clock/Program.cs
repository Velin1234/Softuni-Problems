using System;

namespace _09.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            for (int minute = 0; minute <= 60; minute++)
            {
                if (minute >= 60)
                {
                    minute = 0;
                    hours++;
                }
                if (hours > 23)
                {
                    Environment.Exit(0);
                }
                Console.WriteLine($"{hours} : {minute}");
                
            }
        }
    }
}
