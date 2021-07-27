using System;

namespace _05.Time_Plus_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;

            if (minutes <= 59)
            {
                if (hours <= 23)
                {
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes}");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes}");
                    }
                }
                else
                {
                    hours = 0;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes}");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes}");
                    }
                }
            }
            else
            {
               minutes = minutes % 60;
               hours += 1;
                if (hours <= 23)
                {
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes}");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes}");
                    }
                }
                else
                {
                    hours = 0;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes}");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes}");
                    }
                }
            }
        }
    }
}