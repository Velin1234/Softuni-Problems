using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            
            double standartTickets = 0;
            double studentsTickets = 0;
            double kidsTickets = 0;
            
            string movie = Console.ReadLine();

            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());

                int countOfTickets = 0;
                string ticket = Console.ReadLine();

                while (ticket != "End")
                {
                    switch (ticket)
                    {
                        case "standard":
                            standartTickets++;
                            break;
                        case "student":
                            studentsTickets++;
                            break;
                        case "kid":
                            kidsTickets++;
                            break;
                    }
                    countOfTickets++;
                    if (countOfTickets == availableSeats)
                    {
                        break;
                    }
                    ticket = Console.ReadLine();
                }

                total += countOfTickets;
                double percentOfSeatsTaken = (double)countOfTickets / availableSeats * 100;
                Console.WriteLine($"{movie} - {percentOfSeatsTaken:f2}% full.");
                movie = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {total}");
            
            double percentOfStudentsTickets = (studentsTickets / total) * 100;
            double percentOfStandartTickets = (standartTickets / total) * 100;
            double percentOfKidTickets = (kidsTickets / total) * 100;

            Console.WriteLine($"{percentOfStudentsTickets:f2}% student tickets.");
            Console.WriteLine($"{percentOfStandartTickets:f2}% standard tickets.");
            Console.WriteLine($"{percentOfKidTickets:f2}% kids tickets.");
         
        }
    }
}
