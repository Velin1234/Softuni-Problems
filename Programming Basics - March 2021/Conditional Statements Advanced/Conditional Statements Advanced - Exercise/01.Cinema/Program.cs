using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            double premiere = 12;
            double normal = 7.5;
            double discount = 5;
            double result;

            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            switch (projection)
            {
                case "Premiere":
                    result = premiere * rows * cols;
                    Console.WriteLine($"{result:f2} leva");
                    break;
                
                case "Normal":
                    result = normal * rows * cols;
                    Console.WriteLine($"{result:f2} leva");
                    break;
                
                case "Discount":
                    result = discount * rows * cols;
                    Console.WriteLine($"{result:f2} leva");
                    break;
                
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
