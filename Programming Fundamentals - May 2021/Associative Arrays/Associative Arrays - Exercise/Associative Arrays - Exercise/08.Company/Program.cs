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
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            
            while (companyInfo[0] != "End")
            {
                string companyName = companyInfo[0];
                string employeeId = companyInfo[1];
                if (companies.ContainsKey(companyName))
                {
                    if (!companies[companyName].Contains(employeeId))
                    {
                        companies[companyName].Add(employeeId);
                    }
                }
                else
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(employeeId);
                }
                companyInfo = Console.ReadLine().Split(" -> ").ToList();
            }

            foreach (var company in companies.OrderBy(c => c.Key))
            {
                Console.WriteLine($"{company.Key}");
                Console.WriteLine($"-- {string.Join("\n-- ", company.Value.OrderBy(n => n))}");
            }
        }
    }
}
