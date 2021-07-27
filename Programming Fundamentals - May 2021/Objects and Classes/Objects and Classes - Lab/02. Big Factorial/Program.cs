using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger sum = n;
            for (int i = 1; i < n; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine(sum);
        }
    }
}
