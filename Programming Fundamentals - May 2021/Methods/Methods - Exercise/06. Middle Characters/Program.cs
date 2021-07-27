using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            GetMiddle(word);

        }

        private static void GetMiddle(string word)
        {
            string middle = string.Empty;
            if (word.Length % 2 == 0)
            {
                middle += Convert.ToChar(word[word.Length / 2 - 1]);
                middle += Convert.ToChar(word[word.Length / 2]);
                Console.WriteLine(middle);
            }
            else
            {
                middle += Convert.ToChar(word[word.Length / 2]);
                Console.WriteLine(middle);
            }
        }
    }
}
