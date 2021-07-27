using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int person1help = int.Parse(Console.ReadLine());
            int person2help = int.Parse(Console.ReadLine());
            int person3help = int.Parse(Console.ReadLine());
            int totalPeople = int.Parse(Console.ReadLine());

            int hour = 0;
            int helpedPeoplePerH = person1help + person2help + person3help;

            while (totalPeople > 0)
            {
                hour++;
                if (hour % 4 == 0)
                {
                    continue;
                }
                totalPeople -= helpedPeoplePerH;
            }
            Console.WriteLine($"Time needed: {hour}h.");
        }
    }
}
