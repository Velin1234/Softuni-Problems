using System;

namespace _05.Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            int numbersDividedBy2 = 0;
            int numbersDividedBy3 = 0;
            int numbersDividedBy4 = 0;


            for (int position = 1; position <= n; position++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    numbersDividedBy2 += 1;
                }
                if (number % 3 == 0)
                {
                    numbersDividedBy3 += 1;
                }
                if (number % 4 == 0)
                {
                    numbersDividedBy4 += 1;
                }
            }

            double percentagesDividedBy2 = numbersDividedBy2 / n * 100;
            double percentagesDividedBy3 = numbersDividedBy3 / n * 100;
            double percentagesDividedBy4 = numbersDividedBy4 / n * 100;

            Console.WriteLine($"{percentagesDividedBy2:f2}%");
            Console.WriteLine($"{percentagesDividedBy3:f2}%");
            Console.WriteLine($"{percentagesDividedBy4:f2}%");
        }
    }
}
