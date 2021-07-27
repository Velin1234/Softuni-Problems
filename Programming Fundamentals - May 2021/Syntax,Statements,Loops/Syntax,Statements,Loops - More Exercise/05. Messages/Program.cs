using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                int digits = int.Parse(Console.ReadLine());
                int mainDigit = digits % 10;
                int digitLenght =  digits.ToString().Length;

                switch (mainDigit)
                {
                    case 0:
                        text += " ";
                        break;

                    case 2:
                        switch (digitLenght)
                        {
                            case 1:
                                text += 'a';
                                break;

                            case 2:
                                text += 'b';
                                break;

                            case 3:
                                text += 'c';
                                break;
                        }
                        break;

                    case 3:
                        switch (digitLenght)
                        {
                            case 1:
                                text += 'd';
                                break;

                            case 2:
                                text += 'e';
                                break;

                            case 3:
                                text += 'f';
                                break;
                        }
                        break;

                    case 4:
                        switch (digitLenght)
                        {
                            case 1:
                                text += 'g';
                                break;

                            case 2:
                                text += 'h';
                                break;

                            case 3:
                                text += 'i';
                                break;
                        }
                        break;

                    case 5:
                        switch (digitLenght)
                        {
                            case 1:
                                text += 'j';
                                break;

                            case 2:
                                text += 'k';
                                break;

                            case 3:
                                text += 'l';
                                break;
                        }
                        break;

                    case 6:
                        switch (digitLenght)
                        {
                            case 1:
                                text += 'm';
                                break;

                            case 2:
                                text += 'n';
                                break;

                            case 3:
                                text += 'o';
                                break;
                        }
                        break;

                    case 7:
                        switch (digitLenght)
                        {
                            case 1:
                                text += 'p';
                                break;

                            case 2:
                                text += 'q';
                                break;

                            case 3:
                                text += 'r';
                                break;

                            case 4:
                                text += "s";
                                break;
                        }
                        break;

                    case 8:
                        switch (digitLenght)
                        {
                            case 1:
                                text += 't';
                                break;

                            case 2:
                                text += 'u';
                                break;

                            case 3:
                                text += 'v';
                                break;
                        }
                        break;

                    case 9:
                        switch (digitLenght)
                        {
                            case 1:
                                text += 'w';
                                break;

                            case 2:
                                text += 'x';
                                break;

                            case 3:
                                text += 'y';
                                break;

                            case 4:
                                text += "z";
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine(text);
        }
    }
}
