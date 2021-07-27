using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colItems = Console.ReadLine().Split(", ").ToList();

            string[] actions = Console.ReadLine().Split(" - ");
            while (actions[0] != "Craft!")
            {
                switch (actions[0])
                {
                    case "Collect":
                        if (!colItems.Contains(actions[1]))
                        {
                            colItems.Add(actions[1]);
                        }
                        break;

                    case "Drop":
                        if (colItems.Contains(actions[1]))
                        {
                            colItems.Remove(actions[1]);
                        }
                        break;

                    case "Combine Items":
                        string[] items = actions[1].Split(':');
                        if (colItems.Contains(items[0]))
                        {
                            int itemIndex = colItems.IndexOf(items[0])+ 1;
                            colItems.Insert(itemIndex, items[1]);
                        }
                        break;

                    case "Renew":
                        if (colItems.Contains(actions[1]))
                        {
                            colItems.Remove(actions[1]);
                            colItems.Add(actions[1]);
                        }
                        break;
                }
                actions = Console.ReadLine().Split(" - ");
            }

            Console.WriteLine(string.Join(", ",colItems));
        }
    }
}
