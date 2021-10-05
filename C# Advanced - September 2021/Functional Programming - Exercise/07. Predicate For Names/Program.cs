using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ").Where(name => name.Length <= n).ToList();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
