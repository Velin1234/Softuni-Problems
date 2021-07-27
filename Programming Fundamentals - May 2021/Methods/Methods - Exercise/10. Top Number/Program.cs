using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = SumOfNums(i);
                bool containsOdd = ContainsOddNum(i);
                if (sum % 8 == 0 && containsOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int SumOfNums(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            return sum;
        }

        static bool ContainsOddNum(int number)
        {
            bool containsOdd = false;
            while (number > 0)
            {
                int lastNum = number % 10;
                if (lastNum % 2 != 0)
                {
                    containsOdd = true;
                }
                number = number / 10;
            }
            return containsOdd;
        }
    }
}
