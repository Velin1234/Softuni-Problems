using System;

namespace _06.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "rectangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double area = lenght * width;
                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.Pow(radius, 2) * Math.PI;
                Console.WriteLine($"{area:f3}");
            }
            else if(shape == "triangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = (lenght * height) / 2;
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
