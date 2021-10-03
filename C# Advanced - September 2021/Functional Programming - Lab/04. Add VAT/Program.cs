using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select((double x) => (x += x * 0.2)).ToList();
            foreach (var num in nums)
            {
                Console.WriteLine($"{num:f2}");
            }
        }
    }
}
