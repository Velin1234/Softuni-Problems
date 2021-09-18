using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCars = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                else if (line == "green")
                {
                    for (int i = 0; i < nCars; i++)
                    {
                        if (cars.Count > 0)
                        {
                            var car = cars.Dequeue();
                            Console.WriteLine(car +" passed!");
                            passedCars++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(line);
                }
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
