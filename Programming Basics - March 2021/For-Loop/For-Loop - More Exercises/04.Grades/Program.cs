using System;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double topGraders = 0;
            double veryGoodGraders = 0;
            double goodGraders = 0;
            double failedGraders = 0;
            double classGrade = 0;

            for (int student = 1; student <= students; student++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 5.00)
                {
                    topGraders++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    veryGoodGraders++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    goodGraders++;
                }
                else if (grade < 3.00)
                {
                    failedGraders++;
                }
                classGrade += grade;
            }

            double topPercentage = topGraders / students * 100;
            double veryGoodPercentage = veryGoodGraders / students * 100;
            double goodPercentage = goodGraders / students * 100;
            double failedPercentage = failedGraders / students * 100;
            double avgGrade = classGrade / students;

            Console.WriteLine($"Top students: {topPercentage:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {veryGoodPercentage:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {goodPercentage:f2}%");
            Console.WriteLine($"Fail: {failedPercentage:f2}%");
            Console.WriteLine($"Average: {avgGrade:f2}");
        }
    }
}
