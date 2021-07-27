using System;

namespace _07.School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            const double boysAndGirlsWinter = 9.60;
            const double boysAndGirlsSpring = 7.20;
            const double boysAndGirlsSummer = 15;

            const double mixedWinter = 10;
            const double mixedSpring = 9.50;
            const double mixedSummer = 20;

            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());

            double girlsOrBoysPrice = 0;
            double mixedPrice = 0;
            string boysSport = "";
            string girlsSport = "";
            string mixedSport = "";
            
            //Season Differences
            switch (season)
            {
                case "Winter":
                    girlsOrBoysPrice = numberOfStudents * boysAndGirlsWinter * numberOfNights;
                    mixedPrice = numberOfStudents * mixedWinter * numberOfNights;
                    break;
                
                case "Summer":
                    girlsOrBoysPrice = numberOfStudents * boysAndGirlsSummer * numberOfNights;
                    mixedPrice = numberOfStudents * mixedSummer * numberOfNights;
                    break;
                
                case "Spring":
                    girlsOrBoysPrice = numberOfStudents * boysAndGirlsSpring * numberOfNights;
                    mixedPrice = numberOfStudents * mixedSpring * numberOfNights;
                    break;

            }

            //Discounts
            if (numberOfStudents >= 50)
            {
                girlsOrBoysPrice -= girlsOrBoysPrice * 0.5;
                mixedPrice -= mixedPrice * 0.5;
            }
            else if (numberOfStudents >= 20 && numberOfStudents < 50)
            {
                girlsOrBoysPrice -= girlsOrBoysPrice * 0.15;
                mixedPrice -= mixedPrice * 0.15;
            }
            else if (numberOfStudents < 20 && numberOfStudents >= 10)
            {
                girlsOrBoysPrice -= girlsOrBoysPrice * 0.05;
                mixedPrice -= mixedPrice * 0.05;
            }
            
            //Sport Seasons
            switch (season)
            {
                case "Winter":
                    boysSport = "Judo";
                    girlsSport = "Gymnastics";
                    mixedSport = "Ski";

                    switch (typeOfGroup)
                    {
                        case "boys":
                            Console.WriteLine($"{boysSport} {girlsOrBoysPrice:f2} lv.");
                            break;
                        case "girls":
                            Console.WriteLine($"{girlsSport} {girlsOrBoysPrice:f2} lv.");
                            break;
                        case "mixed":
                            Console.WriteLine($"{mixedSport} {mixedPrice:f2} lv.");
                            break;
                    }
                    break;
                
                case "Summer":
                    boysSport = "Football";
                    girlsSport = "Volleyball";
                    mixedSport = "Swimming";

                    switch (typeOfGroup)
                    {
                        case "boys":
                            Console.WriteLine($"{boysSport} {girlsOrBoysPrice:f2} lv.");
                            break;
                        case "girls":
                            Console.WriteLine($"{girlsSport} {girlsOrBoysPrice:f2} lv.");
                            break;
                        case "mixed":
                            Console.WriteLine($"{mixedSport} {mixedPrice:f2} lv.");
                            break;
                    }
                    break;
                
                case "Spring":
                    boysSport = "Tennis";
                    girlsSport = "Athletics";
                    mixedSport = "Cycling";

                    switch (typeOfGroup)
                    {
                        case "boys":
                            Console.WriteLine($"{boysSport} {girlsOrBoysPrice:f2} lv.");
                            break;
                        case "girls":
                            Console.WriteLine($"{girlsSport} {girlsOrBoysPrice:f2} lv.");
                            break;
                        case "mixed":
                            Console.WriteLine($"{mixedSport} {mixedPrice:f2} lv.");
                            break;
                    }
                    break;
            }
        }
    }
}
