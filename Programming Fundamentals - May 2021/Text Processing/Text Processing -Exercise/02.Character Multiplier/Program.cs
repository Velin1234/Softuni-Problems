using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> @strings = Console.ReadLine().Split(" ").ToList();
            string str1 = @strings[0];
            string str2 = @strings[1];
            int sum = 0;
            if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    sum += Convert.ToChar(str1[i]) * Convert.ToChar(str2[i]);
                }
                int leftLength = str1.Length - str2.Length;
                for (int i = str2.Length; i <= leftLength; i++)
                {
                    sum += Convert.ToChar(str1[i]);
                }
            }
            else if (str1.Length < str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    sum += Convert.ToChar(str1[i]) * Convert.ToChar(str2[i]);
                }
                int leftLength = str2.Length - str1.Length;
                for (int i = str1.Length; i <= leftLength; i++)
                {
                    sum += Convert.ToChar(str2[i]);
                }
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    sum += Convert.ToChar(str1[i]) * Convert.ToChar(str2[i]);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
