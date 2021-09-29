using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> classbook = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] students = Console.ReadLine().Split(" ");
                string studentName = students[0];
                decimal grade = decimal.Parse(students[1]);

                if (classbook.ContainsKey(studentName))
                {
                    classbook[studentName].Add(grade);
                }
                else
                {
                    classbook.Add(studentName, new List<decimal>());
                    classbook[studentName].Add(grade);
                }
            }

            foreach (var student in classbook)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(v => $"{v:f2}"))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
