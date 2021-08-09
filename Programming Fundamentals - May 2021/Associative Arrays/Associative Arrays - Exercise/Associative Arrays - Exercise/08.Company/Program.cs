using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Company
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> companyInfo = Console.ReadLine().Split(" -> ").ToList();
            Dictionary<string, List<string>> employeesIDs = new Dictionary<string, List<string>>();
            while (companyInfo[0] != "End")
            {
                if (employeesIDs.ContainsKey(companyInfo[0]))
                {
                    employeesIDs[companyInfo[0]].Add(companyInfo[1]);

                }
                else
                {
                    employeesIDs.Add(companyInfo[0], new List<string>());
                    employeesIDs[companyInfo[0]].Add(companyInfo[1]);
                }
                companyInfo = Console.ReadLine().Split(" -> ").ToList();
            }

            foreach (var subject in employeesIDs.OrderByDescending(c => c.Key))
            {
                Console.WriteLine($"{subject.Key}");
                Console.WriteLine($"-- {string.Join("\n-- ", subject.Value.OrderBy(n => n))}");
            }
        }
    }
}
