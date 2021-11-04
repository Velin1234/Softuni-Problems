using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> vowels = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Stack<string> consonants = new Stack<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            words.Add("pear", new List<string>());
            words.Add("flour", new List<string>());
            words.Add("pork", new List<string>());
            words.Add("olive", new List<string>());
            List<string> foundWords = new List<string>();

            while (consonants.Count > 0)
            {
                string lastVowel = vowels.Peek();
                string lastConstant = consonants.Peek();
                foreach (var word in words.Keys.ToList())
                {
                    if (word.Contains(lastVowel) || word.Contains(lastConstant))
                    {
                        if (word.Contains(lastVowel) && !words[word].Contains(lastVowel))
                        {
                            words[word].Add(lastVowel);
                        }
                        if (word.Contains(lastConstant) && !words[word].Contains(lastConstant))
                        {
                            words[word].Add(lastConstant);
                        }
                    }
                }
                vowels.Dequeue();
                vowels.Enqueue(lastVowel);
                consonants.Pop();
            }

            foreach (var word in words)
            {
                if (word.Value.Count >= word.Key.Length)
                {
                    foundWords.Add(word.Key);
                }
            }

            Console.WriteLine($"Words found: {foundWords.Count}");
            Console.WriteLine(string.Join("\n", foundWords));
        }
    }
}
