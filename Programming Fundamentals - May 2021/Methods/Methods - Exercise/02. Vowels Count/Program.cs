using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int vowels = 0;
            vowels = GetVowels(word, vowels);
            Console.WriteLine(vowels);
        }

        private static int GetVowels(string word, int vowels)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'A' || word[i] == 'a'
                    || word[i] == 'E' || word[i] == 'e'
                    || word[i] == 'I' || word[i] == 'i'
                    || word[i] == 'O' || word[i] == 'o'
                    || word[i] == 'U' || word[i] == 'u'
                    )
                {
                    vowels++;
                }
            }

            return vowels;
        }
    }
}
