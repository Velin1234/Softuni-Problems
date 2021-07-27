using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split(" ")
                .ToArray();
            string[] arr2 = Console.ReadLine()
                .Split(" ")
                .ToArray();

            List<string> common = new List<string>();

            for (int i = 0; i < arr2.Length; i++)
            {
                
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        common.Add(arr1[j]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",common).Trim());
        }
    }
}
