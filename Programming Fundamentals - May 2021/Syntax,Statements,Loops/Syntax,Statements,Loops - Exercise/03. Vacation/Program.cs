using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsNum = int.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            
            switch (ticketType)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = 8.45 * studentsNum;
                            break;
                        case "Saturday":
                            price = 9.80 * studentsNum;
                            break;
                        case "Sunday":
                            price = 10.46 * studentsNum;
                            break;
                    }
                    if (studentsNum >= 30)
                    {
                        price -= price * 0.15;
                    }
                    break;

                case "Business":
                    if (studentsNum >= 100)
                    {
                        studentsNum -= 10;
                    }
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90 * studentsNum;
                            break;
                        case "Saturday":
                            price = 15.60 * studentsNum;
                            break;
                        case "Sunday":
                            price = 16.00 * studentsNum;
                            break;
                    }
                    break;

                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15 * studentsNum;
                            break;
                        case "Saturday":
                            price = 20 * studentsNum;
                            break;
                        case "Sunday":
                            price = 22.50 * studentsNum;
                            break;
                    }
                    if (studentsNum >= 10 && studentsNum <= 20)
                    {
                        price -= price * 0.05;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
