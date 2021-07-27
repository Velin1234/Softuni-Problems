using System;

namespace _07.World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record_seconds = double.Parse(Console.ReadLine());
            double distance_record_meters = double.Parse(Console.ReadLine());
            double time_swimmed_one_meter = double.Parse(Console.ReadLine());

            double time_swimmed_the_distance = distance_record_meters * time_swimmed_one_meter;
            double slowed_time_resistance = Math.Floor(distance_record_meters / 15) * 12.5;
            double whole_time = time_swimmed_the_distance + slowed_time_resistance;

            if (record_seconds <= whole_time)
            {
                double needed_seconds = whole_time - record_seconds;
                Console.WriteLine($"No, he failed! He was {needed_seconds:f2} seconds slower.");
            }
            else
            {

                Console.WriteLine($" Yes, he succeeded! The new world record is {whole_time:f2} seconds.");
            }
        }
    }
}
