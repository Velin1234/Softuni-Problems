using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string secondWord = Console.ReadLine();
            
            int indexOfWord = secondWord.IndexOf(word);
            while (indexOfWord >= 0)
            {
                secondWord.Remove(indexOfWord, word.Length);
                indexOfWord = secondWord.IndexOf(word);
            }
            Console.WriteLine(secondWord);
        }
    }
}
