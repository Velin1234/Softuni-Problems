using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> aboveAverageList = new List<int>();
            double numbersAvg = numbers.Average();

            foreach (int number in numbers)
            {
                if (number > numbersAvg)
                {
                    aboveAverageList.Add(number);
                }
            }

            List<int> orderedList = aboveAverageList.OrderByDescending(num => num).Take(5).ToList();
            if (orderedList.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", orderedList));
            }
        }
    }
}
