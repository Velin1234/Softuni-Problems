using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int pair = 0; pair < n; pair++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, new List<double>());
                    students[name].Add(grade);
                }
            }

            Dictionary<string, double> formattedStudents = new Dictionary<string, double>();
            
            foreach (var st in students)
            {
                formattedStudents.Add(st.Key, st.Value.Average());
            }
            foreach (var student in formattedStudents.OrderByDescending(g => g.Value))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
 
        }
    }
}
