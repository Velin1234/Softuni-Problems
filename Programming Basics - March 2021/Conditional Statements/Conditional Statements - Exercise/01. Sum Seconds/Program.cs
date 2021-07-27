using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first_time = int.Parse(Console.ReadLine());
            int second_time = int.Parse(Console.ReadLine());
            int third_time = int.Parse(Console.ReadLine());

            int total_time = first_time + second_time + third_time;
            int minutes = total_time / 60;
            double seconds = total_time % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
