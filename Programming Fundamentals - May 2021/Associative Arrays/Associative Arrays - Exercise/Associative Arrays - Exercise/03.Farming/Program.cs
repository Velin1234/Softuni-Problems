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
            }

            foreach (var item in leftMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
