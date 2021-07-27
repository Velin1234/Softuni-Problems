using System;

namespace _06.Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days_of_campany = int.Parse(Console.ReadLine());
            int number_of_cooks = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double money_made_by_one_cook_cakes = cakes * 45;
            double money_made_by_one_cook_waffles = waffles * 5.80;
            double money_made_by_one_cook_pancakes = pancakes * 3.20;
            double gathered_amount_for_one_day = (money_made_by_one_cook_cakes + money_made_by_one_cook_pancakes + money_made_by_one_cook_waffles) * number_of_cooks;
            double gathered_amount_for_whole_campany = gathered_amount_for_one_day * days_of_campany;
            double expenses = gathered_amount_for_whole_campany / 8;
            double final_amount = gathered_amount_for_whole_campany - expenses;
            Console.WriteLine($"{final_amount}");
        }
    }
}
