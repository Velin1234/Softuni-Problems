using System;

namespace _01.Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            double first_pipe_water_per_hour = double.Parse(Console.ReadLine());
            double second_pipe_water_per_hour = double.Parse(Console.ReadLine());
            double hours_worker_absent = double.Parse(Console.ReadLine());

            double first_pipe_water = first_pipe_water_per_hour * hours_worker_absent;
            double second_pipe_water = second_pipe_water_per_hour * hours_worker_absent;
            double whole_water = first_pipe_water + second_pipe_water;

            if (volume < whole_water)
            {
                whole_water -= volume;
                Console.WriteLine($"For {hours_worker_absent:f2} hours the pool overflows with {whole_water:f2}");
            
            }
            else
            {
                double percents_full = (whole_water / volume) * 100;
                double percents_first_pipe =(first_pipe_water/whole_water) *100;
                double percents_second_pipe = (second_pipe_water / whole_water) * 100; ;
                Console.WriteLine($"The pool is {percents_full:f2}% full. Pipe 1: {percents_first_pipe:f2}%. Pipe 2: {percents_second_pipe:f2}%.");
            }
        
        }
    }
}
