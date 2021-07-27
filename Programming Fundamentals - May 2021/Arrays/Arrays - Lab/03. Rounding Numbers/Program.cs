using System;
using System.Linq;
namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] floatNumbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            for (int i = 0; i < floatNumbers.Length; i++)
            {
                double number = Math.Round(floatNumbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{Convert.ToDecimal(floatNumbers[i])} => {Convert.ToDecimal(number)}");
            }
            
        }
    }
}
