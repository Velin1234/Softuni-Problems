using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Valid_Username
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> users = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var user in users)
            {
                if (user.Length < 3 || user.Length > 16)
                {
                    continue;
                }
                bool isValid = false;
                foreach (var symbol in user)
                {
                    if (!(char.IsDigit(symbol) || char.IsLetter(symbol) || symbol == '_' || symbol == '-'))
                    {
                        isValid = false;
                        break;
                    }
                    isValid = true;
                }
                if (isValid)
                {
                    Console.WriteLine(user);
                }
            }
        }
    }
}
