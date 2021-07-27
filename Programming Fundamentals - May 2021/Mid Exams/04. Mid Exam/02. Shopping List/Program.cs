using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceryList = Console.ReadLine().Split('!').ToList();
            string[] actions = Console.ReadLine().Split(' ');
            while (actions[0] != "Go")
            {
                switch (actions[0])
                {
                    case "Urgent":
                        if (!groceryList.Contains(actions[1]))
                        {
                            groceryList.Insert(0, actions[1]);
                        }
                        break;

                    case "Unnecessary":
                        if (groceryList.Contains(actions[1]))
                        {
                            groceryList.Remove(actions[1]);
                        }
                        break;

                    case "Correct":
                        if (groceryList.Contains(actions[1]))
                        {
                            int indexOfOldItem = groceryList.IndexOf(actions[1]);
                            groceryList.Remove(actions[1]);
                            groceryList.Insert(indexOfOldItem, actions[2]);
                        }
                        break;

                    case "Rearrange":
                        if (groceryList.Contains(actions[1]))
                        {
                            groceryList.Remove(actions[1]);
                            groceryList.Add(actions[1]);
                        }
                        break;
                }
                actions = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(", ", groceryList));

        }
    }
}
