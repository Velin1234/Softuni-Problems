using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for (int floor = floors; floor >= 1; floor--)
            {
                for (int room = 0; room < rooms; room++)
                {
                    if (floor == floors)
                    {
                        string lastFloor = "L" + floor + room + " ";
                        Console.Write(lastFloor);
                    }
                    else if (floor % 2 == 0)
                    {
                        string officeFloor = "O" + floor + room + " ";
                        Console.Write(officeFloor);
                    }
                    else
                    {
                        string apartmentsFloor = "A" + floor + room + " ";
                        Console.Write(apartmentsFloor);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
