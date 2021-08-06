using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> materials = Console.ReadLine().Split(" ").ToList();
            Dictionary<string, int> leftMaterials = new Dictionary<string, int>();
            for (int i = 1; i < materials.Count; i+=2)
            {
                if (leftMaterials.ContainsKey(materials[i].ToLower()))
                {
                    leftMaterials[materials[i].ToLower()] += Convert.ToInt32(materials[i - 1]);
                }
                else
                {
                    leftMaterials.Add(materials[i].ToLower(), Convert.ToInt32(materials[i - 1]));
                }

                if (leftMaterials.ContainsKey("fragments") && leftMaterials["fragments"] >= 250)
                {
                    leftMaterials["fragments"] -= 250;
                    Console.WriteLine("Valanyr obtained!");
                    break;
                }
                if (leftMaterials.ContainsKey("shards") && leftMaterials["shards"] >= 250)
                {
                    leftMaterials["shards"] -= 250;
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                }
                if (leftMaterials.ContainsKey("motes") && leftMaterials["motes"] >= 250)
                {
                    leftMaterials["motes"] -= 250;
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
                }
            }

            Dictionary<string, int> mainMaterials = new Dictionary<string, int>();
            if (leftMaterials.ContainsKey("fragments"))
            {
                mainMaterials.Add("fragments", leftMaterials["fragments"]);
                leftMaterials.Remove("fragments");
            }
            if (leftMaterials.ContainsKey("shards"))
            {
                mainMaterials.Add("shards", leftMaterials["shards"]);
                leftMaterials.Remove("shards");
            }
            if (leftMaterials.ContainsKey("motes"))
            {
                mainMaterials.Add("motes", leftMaterials["motes"]);
                leftMaterials.Remove("motes");
            }

            foreach (var main in mainMaterials.OrderByDescending(m => m.Value).ThenBy(m => m.Key))
            {
                Console.WriteLine($"{main.Key}: {main.Value}");
            }
            foreach (var item in leftMaterials.OrderBy(m => m.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
