using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            int numbersHalf = numbers.Count / 2;
            List<double> gaussList = new List<double>();

            for (int i = 0; i < numbersHalf; i++)
            {
                gaussList.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
            }

            if (numbers.Count % 2 !=0)
            {
                gaussList.Add(numbers[numbersHalf]);
            }

            Console.WriteLine(string.Join(" ", gaussList));
        }
    }
}
