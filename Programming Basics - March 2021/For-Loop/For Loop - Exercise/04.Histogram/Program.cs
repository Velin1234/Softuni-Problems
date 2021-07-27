using System;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            int numsUnder200 = 0;
            int numsBetween200And400 = 0;
            int numsBetween400And600 = 0;
            int numsBetween600And800 = 0;
            int numsAbove800 = 0;

            for (int position = 1; position <= n; position++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    numsUnder200 += 1; 
                }
                else if (number >=200 && number <= 399)
                {
                    numsBetween200And400 += 1; ;
                }
                else if (number >= 400 && number <= 599)
                {
                    numsBetween400And600 += 1; ;
                }
                else if (number >= 600 && number <= 799)
                {
                    numsBetween600And800 += 1; ;
                }
                else if(number >= 800)
                {
                    numsAbove800 += 1; 
                }
            }

            double percentageUnder200 = numsUnder200 / n * 100;
            double percentageBetween200And400 = numsBetween200And400 / n * 100;
            double percentageBetween400And600 = numsBetween400And600 / n * 100;
            double percentageBetween600And800 = numsBetween600And800 / n * 100;
            double percentageAbove800 = numsAbove800 / n * 100;
            
            Console.WriteLine($"{percentageUnder200:f2}%");
            Console.WriteLine($"{percentageBetween200And400:f2}%");
            Console.WriteLine($"{percentageBetween400And600:f2}%");
            Console.WriteLine($"{percentageBetween600And800:f2}%");
            Console.WriteLine($"{percentageAbove800:f2}%");
        }
    }
}
