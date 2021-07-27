using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                CheckPalindrome(command);
                command = Console.ReadLine();
            }
        }

        static void CheckPalindrome(string command)
        {
            string reversedString = string.Empty;
            for (int i = command.Length - 1; i >= 0; i--)
            {
                reversedString += command[i];
            }
            if (command == reversedString)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
