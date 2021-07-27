using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers1 = Console.ReadLine()
                 .Split(" ")
                 .Select(double.Parse)
                 .ToList();
            List<double> numbers2 = Console.ReadLine()
                 .Split(" ")
                 .Select(double.Parse)
                 .ToList();

            List<double> combinedList = new List<double>();

            if (numbers1.Count > numbers2.Count)
            {
                GetCombo(numbers1, numbers2, combinedList);
            }
            else
            {
                GetCombo2(numbers1, numbers2, combinedList);
            }
            
           

            Console.WriteLine(string.Join(" ", combinedList));
        }

        private static void GetCombo(List<double> List1, List<double> List2, List<double> combinedList)
        {
            for (int i = 0; i < List1.Count; i++)
            {
                try
                {
                    combinedList.Add(List1[i]);
                }
                catch { } 
                
                try
                {
                    combinedList.Add(List2[i]);
                }
                catch { }
            }
        }

        private static void GetCombo2(List<double> List1, List<double> List2, List<double> combinedList)
        {
            for (int i = 0; i < List2.Count; i++)
            {
                try
                {
                    combinedList.Add(List1[i]);
                }
                catch { }

                try
                {
                    combinedList.Add(List2[i]);
                }
                catch { }
            }
        }
    }
}
