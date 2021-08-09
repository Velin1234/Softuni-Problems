using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(", ").ToList();
            string text = Console.ReadLine();
            foreach (var word in words)
            {
                string hide = "";
                for (int i = 0; i < word.Length; i++)
                {
                    hide+="*";
                }
                text = text.Replace(word, hide);
            }
            Console.WriteLine(text);
        }
    }
}
