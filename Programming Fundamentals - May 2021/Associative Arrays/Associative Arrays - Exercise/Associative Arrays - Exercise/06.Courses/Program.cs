using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentsInfo = Console.ReadLine().Split(" : ").ToList();
            Dictionary<string, List<string>> subjectsInfo = new Dictionary<string, List<string>>();
            while (studentsInfo[0] != "end")
            {
                if (subjectsInfo.ContainsKey(studentsInfo[0]))
                {
                    subjectsInfo[studentsInfo[0]].Add(studentsInfo[1]);

                }
                else
                {
                    subjectsInfo.Add(studentsInfo[0], new List<string>());
                    subjectsInfo[studentsInfo[0]].Add(studentsInfo[1]);
                }
            }
        }
    }
}
