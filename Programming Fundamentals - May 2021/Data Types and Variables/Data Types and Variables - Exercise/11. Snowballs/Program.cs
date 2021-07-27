using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger maxValue = 0;
            string bestResult = string.Empty;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue >= maxValue)
                {
                    maxValue = snowballValue;
                    string result = ($"{snowballSnow} : {snowballTime} = {maxValue} ({snowballQuality})");
                    bestResult = result;
                }
            }
            Console.WriteLine(bestResult);
        }
    }
}
