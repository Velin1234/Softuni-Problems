using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            double factorial1 = GetFactorial(n1);
            double factorial2 = GetFactorial(n2);

            double factorialDifference = factorial1 / factorial2;
            Console.WriteLine($"{Math.Abs(factorialDifference):f2}");


        }

        private static double GetFactorial(int n)
        {
            double factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
