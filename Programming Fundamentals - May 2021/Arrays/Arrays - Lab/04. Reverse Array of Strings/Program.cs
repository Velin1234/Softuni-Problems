﻿using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").ToArray();
            Array.Reverse(words);
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
