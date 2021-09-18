using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string arithmeticExpr = Console.ReadLine();
            Stack<int> indices = new Stack<int>();
            for (int i = 0; i < arithmeticExpr.Length; i++)
            {
                if (arithmeticExpr[i] == '(')
                {
                    indices.Push(i);
                }
                else if (arithmeticExpr[i] == ')')
                {
                    var openBrackedIndex = indices.Pop();
                    var closedBrackedIndex = i;
                    Console.WriteLine(arithmeticExpr.Substring(openBrackedIndex, closedBrackedIndex - openBrackedIndex + 1));
                }
            }
        }
    }
}
