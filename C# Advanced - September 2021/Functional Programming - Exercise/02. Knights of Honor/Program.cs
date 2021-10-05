using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<string>> printCollectioon = input => input.ForEach(x => Console.WriteLine($"Sir {x}"));
            List<string> knights = Console.ReadLine().Split().ToList();
            printCollectioon(knights);
        }
    }
}
