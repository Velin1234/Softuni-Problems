using System;

namespace _05._Digits__Leters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string digits = "";
            string letters = "";
            string symbols = "";
            for (int symbol = 0; symbol < word.Length; symbol++)
            {
                if (char.IsDigit(Convert.ToChar(word[symbol])))
                {
                    digits += word[symbol];
                }
                else if (char.IsLetter(Convert.ToChar(word[symbol])))
                {
                    letters += word[symbol];
                }
                else
                {
                    symbols += word[symbol];
                }
            }
            Console.WriteLine($"{digits}\n" +
                $"{letters}\n" +
                $"{symbols}");
        }
    }
}
