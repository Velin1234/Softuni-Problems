using System;

namespace _05.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght_in_meters = double.Parse(Console.ReadLine());
            double width_in_meters = double.Parse(Console.ReadLine());                        
            double lenght_in_cm = lenght_in_meters * 100;
            double width_in_cm = width_in_meters * 100;
            double width_with_door = width_in_cm - 100;
            double desk_on_row = Math.Floor(width_with_door / 70);
            double rows = Math.Floor(lenght_in_cm / 120);

            double number_of_seats = desk_on_row * rows - 3;
            Console.WriteLine($"{number_of_seats}");
        }
    }
}
