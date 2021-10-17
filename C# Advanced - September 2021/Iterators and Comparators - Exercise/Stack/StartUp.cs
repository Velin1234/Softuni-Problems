using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new MyStack<string>();
            while (true)
            {
                var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "END")
                {
                    break;
                }
                else if (tokens[0] == "Push" || tokens[0] == "push")
                {
                    stack.Push(tokens.Skip(1).Select(el => el.Split(",").First()).ToArray());
                }
                else if (tokens[0] == "Pop" || tokens[0] == "pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch 
                    {
                        Console.WriteLine("No elements");
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var element in stack)
                {
                    Console.WriteLine(element);
                }
            }

        }
    }
}
