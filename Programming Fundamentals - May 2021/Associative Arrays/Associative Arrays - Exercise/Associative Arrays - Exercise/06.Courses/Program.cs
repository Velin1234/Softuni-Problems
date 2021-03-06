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
                studentsInfo = Console.ReadLine().Split(" : ").ToList();
            }

            foreach (var subject in subjectsInfo.OrderByDescending(s => s.Value.Count))
            {
                Console.WriteLine($"{subject.Key}: {subject.Value.Count}");
                Console.WriteLine($"-- {string.Join("\n-- ", subject.Value.OrderBy(n => n))}");
            }
        }
    }
}
