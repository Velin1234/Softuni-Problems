
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> accounts = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                List<string> accountInfo = Console.ReadLine().Split(" ").ToList();
                string name = accountInfo[1];

                switch (accountInfo[0])
                {
                    case "register":
                        string licensePateNum = accountInfo[2];
                        if (accounts.ContainsValue(licensePateNum))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePateNum}");
                        }
                        else
                        {
                            accounts.Add(name, licensePateNum);
                            Console.WriteLine($"{name} registered {licensePateNum} successfully");
                        }
                        break;

                    case "unregister":
                        if (accounts.ContainsKey(name))
                        {
                            accounts.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        break;
                }
            }

            foreach (var acc in accounts)
            {
                Console.WriteLine($"{acc.Key} => {acc.Value}");
            }
        }
    }
}
