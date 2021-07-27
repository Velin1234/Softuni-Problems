using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int evenSum = 0;
            int oddSum = 0;
            GetSumOddsAndEvens(ref number, ref evenSum, ref oddSum);
        }

        private static void GetSumOddsAndEvens(ref int number, ref int evenSum, ref int oddSum)
        {
            while (number > 0)
            {
                int lastNum = number % 10;

                if (lastNum % 2 == 0)
                {
                    evenSum += lastNum;
                }
                else
                {
                    oddSum += lastNum;
                }
                number = number / 10;
            }
            Console.WriteLine(evenSum * oddSum);
        }
    }
}
