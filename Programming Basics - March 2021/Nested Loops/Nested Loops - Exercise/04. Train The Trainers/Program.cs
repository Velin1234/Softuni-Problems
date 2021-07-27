using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int gradesCount = 0;
            double allGrades = 0;
            while (true)
            {
                double sumGrades = 0;

                string name = Console.ReadLine();
                if (name == "Finish")
                {
                    break;
                }
                for (int i = 1; i <= number; i++)
                {
                    double grades = double.Parse(Console.ReadLine());
                    sumGrades += grades;
                    gradesCount++;
                }
                allGrades += sumGrades;
                double avgGrades = sumGrades / number;
                Console.WriteLine($"{name} - {avgGrades:f2}.");
                
            }
            double studentsAvg = allGrades / gradesCount;
            Console.WriteLine($"Student's final assessment is {studentsAvg:f2}.");
            Environment.Exit(0);
        }
    }
}
