﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(w => char.IsUpper(w[0])).ToList();
            
                foreach (var word in words)
                {
                    Console.WriteLine(word);
                }
            
        }
    }
}
