using System;
using System.Collections.Generic;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            NXNMatrix(n);
        }

        private static void NXNMatrix(int n)
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < n; i++)
            {
                nums.Add(n);
            }
            for (int time = 0; time < n; time++)
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }
    }
}
