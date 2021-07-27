using System;

namespace _06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int Tabs = 1; Tabs <= openTabs; Tabs++)
            {
                string websites = Console.ReadLine();
                switch (websites)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    
                    case "Instagram":
                        salary -= 100;
                        break;
                    
                    case "Reddit":
                        salary -= 50;
                        break;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
