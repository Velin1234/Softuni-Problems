using System;

namespace _08.Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int clas = 0;
            int failedClass = 0;
            double allGrades = 0;
            
            while (clas < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    allGrades += grade;
                    clas++;
                }
                else
                {
                    failedClass++;
                    clas++;
                }
                if (failedClass >= 2)
                {
                    Console.WriteLine($"{name} has been excluded at {clas-1} grade");
                    Environment.Exit(0);
                }
            }
            double avgGrade = allGrades / clas;
            Console.WriteLine($"{name} graduated. Average grade: {avgGrade:f2}");
        }
    }
}
