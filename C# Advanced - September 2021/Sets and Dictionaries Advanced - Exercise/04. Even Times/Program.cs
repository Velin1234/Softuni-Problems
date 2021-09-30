using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> ocurrances = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string num = Console.ReadLine();
                if (!ocurrances.ContainsKey(num))
                {
                    ocurrances.Add(num, 0);
                }
                ocurrances[num]++;
            }
            Console.WriteLine(ocurrances.First(o => o.Value % 2 == 0).Key);
        }
    }
}
