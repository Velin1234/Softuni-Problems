using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(" ").ToArray();
            List<string> lowerElements = new List<string>();


            Dictionary<string, int> counts = new Dictionary<string, int>();
            List<string> oddOccurences = new List<string>();

            foreach (var word in elements)
            {
                lowerElements.Add(word.ToLower());
            }


            foreach (string item in lowerElements)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts.Add(item, 1);
                }
            }

            foreach (var element in counts)
            {
                if (element.Value % 2 != 0)
                {
                    oddOccurences.Add(element.Key);
                }
            }

            Console.WriteLine(string.Join(" ", oddOccurences));
        }
    }
}
