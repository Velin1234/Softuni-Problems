using System;

namespace _02.Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int rest_days = int.Parse(Console.ReadLine());
            int play_minutes = rest_days * 127;
            int work_days = 365 - rest_days;
            int work_time = work_days * 63;
            int whole_time = play_minutes + work_time;
            if (whole_time < 30000)
            {
                int time_left = 30000 - whole_time;
                int whole_time_to_minutes = time_left % 60;
                int whole_time_to_hours = time_left / 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{whole_time_to_hours} hours and {whole_time_to_minutes} minutes less for play");
            }
            else
            {
                int more_time = whole_time - 30000;
                int whole_time_to_minutes = more_time % 60;
                int whole_time_to_hours = more_time / 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{whole_time_to_hours} hours and {whole_time_to_minutes} minutes more for play");
            }            
        }
    }
}
