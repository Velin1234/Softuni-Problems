using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int nStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < nStudents; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                Student student = new Student(input[0],input[1],Convert.ToDouble(input[2]));
                students.Add(student);
            
            }
            List<Student> orderedStudents = new List<Student>();
            orderedStudents = students.OrderByDescending(s => s.Grade).ToList();

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
