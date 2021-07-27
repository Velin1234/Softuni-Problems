using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int num1 = 0; num1 <= num; num1++)
            {
                for (int num2 = 0; num2 <= num; num2++)
                {
                    for (int num3 = 0; num3 <= num; num3++)
                    {
                        int sum = num1 + num2 + num3;

                        if (num == sum)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
