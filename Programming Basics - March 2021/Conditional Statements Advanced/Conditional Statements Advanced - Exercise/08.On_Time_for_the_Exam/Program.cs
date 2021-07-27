using System;

namespace _08.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int exam_hour = int.Parse(Console.ReadLine());
            int exam_minute = int.Parse(Console.ReadLine());
            int arrive_hour = int.Parse(Console.ReadLine());
            int arrive_minute = int.Parse(Console.ReadLine());

            int exam_total_minutes = exam_hour * 60 + exam_minute;
            int arrive_total_minutes = arrive_hour * 60 + arrive_minute;

            if (arrive_total_minutes > exam_total_minutes)
            {
                Console.WriteLine("Late");
                int late = arrive_total_minutes - exam_total_minutes;
                int late_hour = late / 60;
                int late_minute = late % 60;
                
                if (late_hour == 0)
                {
                    Console.WriteLine($"{late_minute} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{late_hour}:{late_minute:D2} hours after the start");
                }

            }
            else if (arrive_total_minutes < exam_total_minutes - 30)
            {
                Console.WriteLine("Early");
                int early = exam_total_minutes - arrive_total_minutes;
                int early_hour = early / 60;
                int early_minute = early % 60;

                if (early_hour == 0)
                {
                    Console.WriteLine($"{early_minute} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{early_hour}:{early_minute:D2} hours before the start");
                }

            }
            else
            {
                Console.WriteLine("On time");
                int onTime = exam_total_minutes - arrive_total_minutes;
                int onTime_minute = onTime % 60;

                if (onTime_minute !=0)
                {
                    Console.WriteLine($"{onTime_minute} minutes before the start");
                }
            }
        
        }
    }
}
