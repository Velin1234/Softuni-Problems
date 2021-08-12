﻿using System;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(\-|\ )2\1\d{3}\1\d{4}\b";
            string phones = Console.ReadLine();
            MatchCollection matches = Regex.Matches(phones, pattern);
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
