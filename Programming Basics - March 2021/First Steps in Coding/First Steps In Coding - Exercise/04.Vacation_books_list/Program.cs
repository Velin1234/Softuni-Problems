using System;

namespace _04.Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages_in_book = int.Parse(Console.ReadLine());
            double pages_per_hour = double.Parse(Console.ReadLine());
            int days_to_complete_book = int.Parse(Console.ReadLine());
            double whole_time_to_complete_book = pages_in_book / pages_per_hour;
            double hours_per_day_to_complete_book = whole_time_to_complete_book / days_to_complete_book;
            Console.WriteLine($"{hours_per_day_to_complete_book}");
        }
    }
}
