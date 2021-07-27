using System;

namespace _10._Clock___part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            int minutes = 0;
            for (int seconds = 0; seconds <= 60; seconds++)
            {
                if (seconds >= 60)
                {
                    seconds = 0;
                    minutes++;
                }
                if (minutes >= 60)
                {
                    minutes = 0;
                    hours++;
                }                
                if (hours > 23)
                {
                    Environment.Exit(0);
                }
                Console.WriteLine($"{hours} : {minutes} : {seconds}");

            }
        }
    }
}
