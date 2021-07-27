using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int trashedHeadset = 0;
            int trashedMouse = 0;
            int trashedKeyboard = 0;
            int trashedDisplay = 0;
            int keyboardTrigger = 0;

            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());


            for (int i = 1; i <= lostGames; i++)
            {

                if (i % 3 == 0 && i % 2 == 0)
                {
                    trashedHeadset++;
                    trashedMouse++;
                    trashedKeyboard++;
                    keyboardTrigger++;
                }
                else if (i % 2 == 0)
                {
                    trashedHeadset++;
                }
                else if (i % 3 == 0)
                {
                    trashedMouse++;
                }

                if (keyboardTrigger % 2 == 0 && keyboardTrigger > 0)
                {
                    trashedDisplay++;
                    keyboardTrigger = 0;
                }
            }

            double rageExpenses = trashedHeadset * headsetPrice + trashedMouse * mousePrice + trashedKeyboard * keyboardPrice + trashedDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
            //Console.WriteLine($"Trashed headset -> {trashedHeadset} times");
            //Console.WriteLine($"Trashed mouse -> {trashedMouse} times");
            //Console.WriteLine($"Trashed keyboard -> {trashedKeyboard} times");
            //Console.WriteLine($"Trashed display -> {trashedDisplay} times");


        }
    }
}
