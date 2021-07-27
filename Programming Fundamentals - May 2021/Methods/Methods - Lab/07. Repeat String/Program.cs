using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            string apendedWord = string.Empty;
            apendedWord = AppendWord(word, times, apendedWord);
            Console.WriteLine(apendedWord);
        }

        private static string AppendWord(string word, int times, string apendedWord)
        {
            for (int i = 0; i < times; i++)
            {
                apendedWord += word;
            }
            
            return apendedWord;
        }
    }
}
