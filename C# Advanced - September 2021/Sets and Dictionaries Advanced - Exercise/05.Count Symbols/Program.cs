using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!chars.ContainsKey(input[i]))
                {
                    chars.Add(input[i], 1);
                }
                else
                {
                    chars[input[i]]++;
                }
            }

            foreach (var letter in chars.OrderBy(c => c.Key))
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
