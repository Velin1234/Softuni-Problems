using System;
using System.Collections.Generic;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            double initBonus = double.Parse(Console.ReadLine());

            double maxBonus = 0;
            double studentLecturesWithMostBonus = 0;

            for (int i = 0; i < students; i++)
            {
                double attendacies = double.Parse(Console.ReadLine());
                double totalBonus = attendacies / lectures * (5 + initBonus);
                totalBonus = Math.Ceiling(totalBonus);
                if (maxBonus < totalBonus)
                {
                    maxBonus = totalBonus;
                    studentLecturesWithMostBonus = attendacies;
                }
            }

            Console.WriteLine($"Max Bonus: {maxBonus}. \nThe student has attended {studentLecturesWithMostBonus} lectures.");
        }
    }
}
