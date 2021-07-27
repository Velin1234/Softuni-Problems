using System;
using System.Collections.Generic;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> namesCode = new List<int>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int sum = 0;
                for (int letter = 0; letter < name.Length; letter++)
                {
                    if (name[letter] == 'A' || name[letter] == 'a' || name[letter] == 'E' || name[letter] == 'e'
                         || name[letter] == 'I' || name[letter] == 'i' || name[letter] == 'O' || name[letter] == 'o'
                          || name[letter] == 'U' || name[letter] == 'u')
                    {
                        sum += name[letter] * name.Length;
                    }
                    else
                    {
                        sum += name[letter] / name.Length;
                    }
                }
                namesCode.Add(sum);
            }
            namesCode.Sort();
            Console.WriteLine(string.Join("\n",namesCode));
        }
    }
}
