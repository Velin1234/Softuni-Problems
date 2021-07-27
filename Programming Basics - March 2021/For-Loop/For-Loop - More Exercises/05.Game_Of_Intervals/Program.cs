using System;

namespace _05.Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int turns = int.Parse(Console.ReadLine());
            double result = 0;
            double zeroToNine = 0;
            double tenToNineteen = 0;
            double twentyToTwentyNine = 0;
            double thirtyToThirtyNine = 0;
            double fortyToFifty = 0;
            double invalidNumbers = 0;

            for (int numbers = 1; numbers <= turns; numbers++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number >= 0 && number <= 9)
                {
                    zeroToNine++;
                    result += number * 0.2;
                }
                else if (number >= 10 && number <= 19)
                {
                    tenToNineteen++;
                    result += number * 0.3;
                }
                else if (number >= 20 && number <= 29)
                {
                    twentyToTwentyNine++;
                    result += number * 0.4;
                }
                else if (number >= 30 && number <= 39)
                {
                    thirtyToThirtyNine++;
                    result += 50;
                }
                else if (number >= 40 && number <= 50)
                {
                    fortyToFifty++;
                    result += 100;
                }
                else if(number > 50 || number < 0)
                {
                    invalidNumbers++;
                    result /= 2;
                }
            }
            double zeroToNinePercentage = zeroToNine / turns * 100;
            double tentoNineteenPercentage = tenToNineteen / turns * 100;
            double twentyToTwentyNinePercentage = twentyToTwentyNine / turns * 100;
            double thirtyToThirtyNinePercentage = thirtyToThirtyNine / turns * 100;
            double fortyToFiftyPercentage = fortyToFifty / turns * 100;
            double invalidNumbersPercentage = invalidNumbers / turns * 100;

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {zeroToNinePercentage:f2}%");
            Console.WriteLine($"From 10 to 19: {tentoNineteenPercentage:f2}%");
            Console.WriteLine($"From 20 to 29: {twentyToTwentyNinePercentage:f2}%");
            Console.WriteLine($"From 30 to 39: {thirtyToThirtyNinePercentage:f2}%");
            Console.WriteLine($"From 40 to 50: {fortyToFiftyPercentage:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbersPercentage:f2}%");
        }
    }
}
