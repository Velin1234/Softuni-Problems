﻿using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(string.Join("",text[i]));
            }
        }
    }
}
