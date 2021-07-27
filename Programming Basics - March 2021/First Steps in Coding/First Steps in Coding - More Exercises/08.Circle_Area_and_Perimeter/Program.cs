using System;

namespace _08.Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double circle_area = Math.PI * Math.Pow(radius, 2);
            double circle_perimeter = 2 * Math.PI * radius;

            Console.WriteLine($"{circle_area:f2}");
            Console.WriteLine($"{circle_perimeter:f2}");
        }
    }
}
