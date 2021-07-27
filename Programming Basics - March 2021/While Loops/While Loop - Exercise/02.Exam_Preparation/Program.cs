using System;

namespace _02.Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int badGradesCounter = 0;

            bool flag = false;
            int numberOfProblems = 0;
            double allGrades = 0;
            string lastProblem = "";

            while (badGrades > badGradesCounter)
            {
                string excerciseName = Console.ReadLine();

                if (excerciseName == "Enough")
                {
                    flag = true;
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                numberOfProblems++;
                allGrades += grade;

                if (grade <= 4.00)
                {
                    badGradesCounter++;
                }

                lastProblem = excerciseName;
            }

            double avgScore = allGrades / numberOfProblems;

            if (flag)
            {
                Console.WriteLine($"Average score: {avgScore:f2}");
                Console.WriteLine($"Number of problems: {numberOfProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
            }

        }
    }
}
