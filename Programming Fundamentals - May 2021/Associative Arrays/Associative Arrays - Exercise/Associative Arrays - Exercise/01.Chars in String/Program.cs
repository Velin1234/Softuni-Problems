using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Chars_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!chars.ContainsKey(words[i]) && words[i] != ' ')
                {
                    chars.Add(words[i],1);
                }
                else
                {
                    if (words[i] != ' ')
                    {
                        chars[words[i]]++;
                    }
                }

            }

            foreach (var @char in chars)
            {
                Console.WriteLine($"{@char.Key} -> {@char.Value}");
            }
        }
    }
}

