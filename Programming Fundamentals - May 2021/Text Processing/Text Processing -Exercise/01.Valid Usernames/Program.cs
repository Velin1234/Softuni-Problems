using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine().Split(", ").ToList();
            
            foreach (var user in usernames)
            {
                if (user.Length >= 3 || user.Length <= 16)
                {
                    continue;
                }

                bool isValid = false;
                
                foreach (var symbol in user)
                {
                    if (!(char.IsDigit(symbol) || char.IsLetter(symbol) || symbol == '-' || symbol == '_'))
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
