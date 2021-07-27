using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours_to_finish = int.Parse(Console.ReadLine());
            int available_days = int.Parse(Console.ReadLine());
            int number_employess_working_overtime = int.Parse(Console.ReadLine());

            double working_hours = (available_days - available_days * 0.1) * 8 ;
            double overtime_hours = number_employess_working_overtime * 2 * available_days;
            double whole_working_hours = Math.Floor(working_hours + overtime_hours);

            if (whole_working_hours >= hours_to_finish)
            {
                double left_hours = (whole_working_hours - hours_to_finish);
                Console.WriteLine($"Yes!{left_hours} hours left.");
            }
            else
            {
                double needed_hours = hours_to_finish - whole_working_hours;
                Console.WriteLine($"Not enough time!{needed_hours} hours needed.");
            }
        }
    }
}
