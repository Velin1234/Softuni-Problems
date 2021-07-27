using System;

namespace _03.Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            double OddSum = 0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;
            double EvenSum = 0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;

            for (int position = 1; position <= numbers; position++)
            {
                double number = double.Parse(Console.ReadLine());
                if (position % 2 == 0)
                {
                    EvenSum += number;
                    if (number > EvenMax)
                    {
                        EvenMax = number;
                    }
                    if (number < EvenMin)
                    {
                        EvenMin = number;
                    }
                }
                else
                {
                    OddSum += number;
                    if (number > OddMax)
                    {
                        OddMax = number;
                    }
                    if (number < OddMin)
                    {
                        OddMin = number;
                    }
                    
                }
            }

            if (numbers == 1)
            {
                Console.WriteLine($"OddSum={OddSum:f2},");
                Console.WriteLine($"OddMin={OddMin:f2},");
                Console.WriteLine($"OddMax={OddMax:f2},");
                Console.WriteLine($"EvenSum={EvenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else if (numbers == 0)
            {
                Console.WriteLine($"OddSum={OddSum:f2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={EvenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={OddSum:f2},");
                Console.WriteLine($"OddMin={OddMin:f2},");
                Console.WriteLine($"OddMax={OddMax:f2},");
                Console.WriteLine($"EvenSum={EvenSum:f2},");
                Console.WriteLine($"EvenMin={EvenMin:f2},");
                Console.WriteLine($"EvenMax={EvenMax:f2}");
            }
            
        }
    }
}
