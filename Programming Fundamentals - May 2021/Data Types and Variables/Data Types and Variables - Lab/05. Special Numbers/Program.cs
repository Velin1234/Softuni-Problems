using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool result;

            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                Console.WriteLine($"{i} -> {result}");
            }
        }
    }
}
