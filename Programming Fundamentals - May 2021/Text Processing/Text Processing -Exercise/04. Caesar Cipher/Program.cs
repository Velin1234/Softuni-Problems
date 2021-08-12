using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder password = new StringBuilder();
            for (int letter = 0; letter < text.Length; letter++)
            {
                int newLetter = text[letter] + 3;
                char passLetter = Convert.ToChar(newLetter);
                password.Append(passLetter);
            }
            Console.WriteLine(password);

        }
    }
}
