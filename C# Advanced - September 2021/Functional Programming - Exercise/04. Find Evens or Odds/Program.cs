using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isOdd = number => number % 2 != 0;
            List<int> numbers = new List<int>();
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string type = Console.ReadLine();
            for (int i = range[0]; i <= range[1]; i++)
            {
                switch (type)
                {
                    case "odd":
                        if (isOdd(i))
                        {
                            numbers.Add(i);
                        }
                        break;
                    case "even":
                        if (isEven(i))
                        {
                            numbers.Add(i);
                        }
                        break;
                    default:
                        break;
                }
                
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
