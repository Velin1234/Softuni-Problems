using System;

namespace _10.Multiply_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number > -1)
            {
                double result = number * 2;
                Console.WriteLine($"Result: {result:f2}");
                while (number >= 0)
                {                    
                    double secondNumber = double.Parse(Console.ReadLine());
                    if (secondNumber >= 0)
                    {
                        double secondResult = secondNumber * 2;
                        Console.WriteLine($"Result: {secondResult:f2}");
                    }
                    else
                    {
                        Console.WriteLine("Negative number!");
                        Environment.Exit(1);
                    }
                }
            }
            else
            {
                Console.WriteLine("Negative number!");
            }
        }
    }
}
