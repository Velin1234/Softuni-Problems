using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> quantityAndMaterials = new List<string>();

            var keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            keyMaterials.Add("shards", 0);

            var junk = new Dictionary<string, int>();

            bool checker = false;

            while (true)
            {
                if (checker == true) break;
                quantityAndMaterials = Console.ReadLine().Split(' ').ToList();
                for (int i = 0; i < quantityAndMaterials.Count; i += 2)
                {
                    string tokenOne = quantityAndMaterials[i]; // number (value)
                    string tokenTwo = quantityAndMaterials[i + 1].ToLower(); // material (key)

                    if (!keyMaterials.ContainsKey(tokenTwo))
                    {
                        junk.Add(tokenTwo, 0);
                        junk[tokenTwo] += int.Parse(tokenOne);
                    }
                    else
                    {
                        keyMaterials[tokenTwo] += int.Parse(tokenOne);
                    }

                    if (keyMaterials["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        keyMaterials["shardes"] -= 250;
                        foreach (var kvp in keyMaterials)
                        {
                            string material = kvp.Key;
                            int count = kvp.Value;
                            Console.WriteLine($"{material}: {count}");
                        }
                        foreach (var kvp in junk)
                        {
                            string material = kvp.Key;
                            int count = kvp.Value;
                            Console.WriteLine($"{material}: {count}");
                        }
                        checker = true;
                        break;
                    }
                    else if (keyMaterials["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        keyMaterials["fragments"] -= 250;
                        foreach (var kvp in keyMaterials)
                        {
                            string material = kvp.Key;
                            int count = kvp.Value;
                            Console.WriteLine($"{material}: {count}");
                        }
                        foreach (var kvp in junk)
                        {
                            string material = kvp.Key;
                            int count = kvp.Value;
                            Console.WriteLine($"{material}: {count}");
                        }
                        checker = true;
                        break;
                    }
                    else if (keyMaterials["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        keyMaterials["motes"] -= 250;
                        foreach (var kvp in keyMaterials)
                        {
                            string material = kvp.Key;
                            int count = kvp.Value;
                            Console.WriteLine($"{material}: {count}");
                        }
                        foreach (var kvp in junk)
                        {
                            string material = kvp.Key;
                            int count = kvp.Value;
                            Console.WriteLine($"{material}: {count}");
                        }
                        checker = true;
                        break;
                    }

                }
            }
        }
    }
}