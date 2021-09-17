using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> equation = new Stack<string>();
            string[] input = Console.ReadLine().Split(" ").ToArray();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                equation.Push(Convert.ToString(input[i]));
            }
            int result = Convert.ToInt32(equation.Peek());
            equation.Pop();

            while (equation.Count != 0)
            {
                if (equation.Peek() == "+")
                {
                    equation.Pop();
                    result += Convert.ToInt32(equation.Peek());
                    equation.Pop();
                }
                else if (equation.Peek() == "-")
                {
                    equation.Pop();
                    result -= Convert.ToInt32(equation.Peek());
                    equation.Pop();
                }
            }
            
            Console.WriteLine(result);
        }
    }
}
