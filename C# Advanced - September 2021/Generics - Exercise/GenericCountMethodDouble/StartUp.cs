using System;

namespace GenericCountMethodDouble
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
            }
            double compareTo = double.Parse(Console.ReadLine());
            Console.WriteLine(box.CountGreaterThan(compareTo));
        }
    }
}
