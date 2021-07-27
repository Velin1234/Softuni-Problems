using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentInfo = Console.ReadLine().Split(" ");
            List<Student> students = new List<Student>();
            while (studentInfo[0] != "end")
            {
                string firstname = studentInfo[0];
                string lastname = studentInfo[1];
                int age = Convert.ToInt32(studentInfo[2]);
                string hometown = studentInfo[3];

                Student student = new Student();
                student.FirstName = firstname;
                student.LastName = lastname;
                student.Age = age;
                student.Hometown = hometown;

                students.Add(student);
                studentInfo = Console.ReadLine().Split(" ");
            }
            string city = Console.ReadLine();

            List<Student> filteredList = students.Where(s => s.Hometown == city).ToList();
            
            foreach (Student student in filteredList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
}
