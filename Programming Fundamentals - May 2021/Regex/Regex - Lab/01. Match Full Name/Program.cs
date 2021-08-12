using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"[A-Z][a-z]+ [A-Z][a-z]+";
            string names = Console.ReadLine();
            MatchCollection matchedNames = Regex.Matches(names, regex);
            foreach (Match name in matchedNames)
            {
                Console.WriteLine($"{name.Value}" +" ");
            }
        }
    }
}
