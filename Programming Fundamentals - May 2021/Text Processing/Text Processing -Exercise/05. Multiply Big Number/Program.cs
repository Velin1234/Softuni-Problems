using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigNum = BigInteger.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            Console.WriteLine(bigNum * multiplier);
        }
    }
}
