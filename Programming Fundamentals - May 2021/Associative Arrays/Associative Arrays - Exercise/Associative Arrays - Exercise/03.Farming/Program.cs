using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mainMaterials = new Dictionary<string, int>();
            mainMaterials.Add("shards",0);
            mainMaterials.Add("fragments",0);
            mainMaterials.Add("motes",0);

            Dictionary<string, int> junks = new Dictionary<string, int>();
            List<string> materials = Console.ReadLine().Split(" ").ToList();
            bool flag = true;

            while (true)
            {
                for (int m = 1; m <= materials.Count; m+=2)
                {
                    int quanity = Convert.ToInt32(materials[m-1]);
                    string material = materials[m].ToLower();
                    
                    if (material == "shards")
                    {
                        mainMaterials["shards"] += quanity;
                    }
                    else if (material == "fragments")
                    {
                        mainMaterials["fragments"] += quanity;
                    }
                    else if (material == "motes")
                    {
                        mainMaterials["motes"] += quanity;
                    }
                    else
                    {
                        if (junks.ContainsKey(material))
                        {
                            junks[material] += quanity;
                        }
                        else
                        {
                            junks.Add(material,quanity);
                        }
                    }

                    if (mainMaterials["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained");
                        mainMaterials["fragments"] -= 250;
                        flag = false;
                        break;
                    }
                    else if (mainMaterials["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained");
                        mainMaterials["shards"] -= 250;
                        flag = false;
                        break;
                    }
                    else if (mainMaterials["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained");
                        mainMaterials["motes"] -= 250;
                        flag = false;
                        break;
                    }
                }
                if (!flag)
                {
                    break;
                }
                materials = Console.ReadLine().Split(" ").ToList();
            }

            foreach (var mainM in mainMaterials.OrderByDescending(m => m.Value).ThenBy(m => m.Key))
            {
                Console.WriteLine($"{mainM.Key}: {mainM.Value}");
            }
            foreach (var junk in junks.OrderBy(j => j.Key))
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }

        }
    }
}