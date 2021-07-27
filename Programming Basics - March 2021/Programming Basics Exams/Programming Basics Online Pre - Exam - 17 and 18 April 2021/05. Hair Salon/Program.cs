using System;

namespace _05._Hair_Salon
{
    class Program
    {
        static void Main(string[] args)
        {
            double target = int.Parse(Console.ReadLine());
            double earnedMoney = 0;
            string hairWork = Console.ReadLine();
            while(hairWork!= "closed")
            {
                
                string work = Console.ReadLine();
                switch (hairWork)
                {
                    case "haircut":
                        switch (work)
                        {
                            case "mens":
                                earnedMoney += 15;
                                break;

                            case "ladies":
                                earnedMoney += 20;
                                break;

                            case "kids":
                                earnedMoney += 10;
                                break;
                        }
                        break;
                    
                    case "color":
                        switch (work)
                        {
                            case "touch up":
                                earnedMoney += 20;
                                break;
                            
                            case "full color":
                                earnedMoney += 30;
                                break;
                        }
                        break;
                }
                if (earnedMoney >= target)
                {
                    break;
                }
                hairWork = Console.ReadLine();
            }

            if (target <= earnedMoney)
            {
                Console.WriteLine("You have reached your target for the day!");
                Console.WriteLine($"Earned money: {earnedMoney}lv.");
            }
            else
            {

                Console.WriteLine($"Target not reached! You need {target-earnedMoney}lv. more.");
                Console.WriteLine($"Earned money: {earnedMoney}lv.");
            }
        }   
    }
}
