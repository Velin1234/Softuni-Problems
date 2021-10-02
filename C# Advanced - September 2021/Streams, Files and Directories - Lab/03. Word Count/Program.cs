using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();


            using (StreamReader wordsReader = new StreamReader(@"C:\Users\venit\Downloads\Resources\03. Word Count\words.txt"))
            {
                string[] words = wordsReader.ReadLine().Split(" ");
                foreach (var word in words)
                {
                    wordCount.Add(word, 0);
                }
            }

            using (StreamReader inputReader = new StreamReader(@"C:\Users\venit\Downloads\Resources\03. Word Count\text.txt"))
            {
                var line = inputReader.ReadLine();
                while (line != null)
                {
                    
                    foreach (var word in wordsInInput)
                    {
                        foreach (var w in wordCount.Keys)
                        {
                            if (word == w)
                            {
                                wordCount[w]++;
                            }
                        }
                    }
                    line = inputReader.ReadLine();
                }
            }

            var ordered = wordCount.OrderBy(w => w.Value);
            foreach (var word in ordered)
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}
