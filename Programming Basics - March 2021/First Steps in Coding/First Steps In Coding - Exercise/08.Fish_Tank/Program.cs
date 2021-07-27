using System;

namespace _08.Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            double volume = length * width * height;
            double liters_it_can_contain = volume * 0.001;
            double percentage_filled = percentage * 0.01;
            double needed_liters = liters_it_can_contain * (1 - percentage_filled);
            Console.WriteLine($"{needed_liters}");
        }
    }
}
