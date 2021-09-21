using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRotations = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> pushedPhrases = new Stack<string>();
            for (int i = 0; i < numberRotations; i++)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "1":
                        pushedPhrases.Push(text.ToString());
                        string strToAppend = command[1];
                        text.Append(strToAppend);
                        break;
                    case "2":
                        pushedPhrases.Push(text.ToString());
                        int countChars = int.Parse(command[1]);
                        text.Remove(text.Length - countChars, countChars);
                        break;
                    case "3":
                        int index = int.Parse(command[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case "4":
                        if (text.Length == 0)
                        {
                            text.Append(pushedPhrases.Pop());
                        }
                        else
                        {
                            text.Replace(text.ToString(), pushedPhrases.Pop());
                        }
                        break;
                }
            }
        }
    }
}
