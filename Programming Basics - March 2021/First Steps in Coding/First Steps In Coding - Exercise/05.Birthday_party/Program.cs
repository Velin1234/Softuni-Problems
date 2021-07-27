using System;

namespace _05.Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double price_cake = (rent /100) * 20;
            double price_drinks = price_cake - ((price_cake / 100) * 45);
            double animator_salary = rent / 3 ;
            double full_price = rent + price_cake + price_drinks + animator_salary;
            Console.WriteLine($"{full_price}");
        }
    }
}
