using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] chemichals = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (var chem in chemichals)
                {
                    elements.Add(chem);
                }
            }
            Console.WriteLine(string.Join(" ", elements.OrderBy(e => e)));
        }
    }
}
