using System;

namespace _01.Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int counter = 0;
            string nextBook = Console.ReadLine();
            bool foundBook = false;
            
            while (nextBook != "No More Books")
            {
                if (nextBook == favouriteBook)
                {
                    foundBook = true;
                    break;
                }
                counter++;
                nextBook = Console.ReadLine();
            }
            
            if (foundBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
