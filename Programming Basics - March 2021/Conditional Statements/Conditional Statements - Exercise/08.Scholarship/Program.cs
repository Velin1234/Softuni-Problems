using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double average_grade = double.Parse(Console.ReadLine());
            double minimal_salary = double.Parse(Console.ReadLine());

            double social_scholarship = Math.Floor(minimal_salary * 0.35);
            double grade_scholarship = Math.Floor(average_grade * 25);

            if (average_grade >= 4.50)
            {
                if (income < minimal_salary && average_grade < 5.50)
                {
                    Console.WriteLine($"You get a Social scholarship {social_scholarship} BGN");
                }
                else if(income < minimal_salary && average_grade >= 5.50)
                {
                    if (grade_scholarship >= social_scholarship)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {grade_scholarship} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a Social scholarship {social_scholarship} BGN");
                    }
                }
                else if(average_grade >= 5.50)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {grade_scholarship} BGN");
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
