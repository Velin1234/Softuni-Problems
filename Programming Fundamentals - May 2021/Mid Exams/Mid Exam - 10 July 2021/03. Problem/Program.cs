using System;
using System.Collections.Generic;

namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chatLog = new List<string>();
            string[] commands = Console.ReadLine().Split(" ");
            while (commands[0] != "end")
            {
                switch (commands[0])
                {
                    case "Chat":
                        chatLog.Add(commands[1]);
                        break;

                    case "Delete":
                        if (chatLog.Contains(commands[1]))
                        {
                            chatLog.Remove(commands[1]);
                        }
                        break;

                    case "Edit":
                        if (chatLog.Contains(commands[1]))
                        {
                            int indexOfOldMessage = chatLog.IndexOf(commands[1]);
                            chatLog.Insert(indexOfOldMessage, commands[2]);
                            chatLog.Remove(commands[1]);
                        }
                        break;

                    case "Pin":
                        if (chatLog.Contains(commands[1]))
                        {
                            chatLog.Remove(commands[1]);
                            chatLog.Add(commands[1]);
                        }
                        break;

                    case "Spam":
                        for (int message = 1; message < commands.Length; message++)
                        {
                            chatLog.Add(commands[message]);
                        }
                        break;
                }
                commands = Console.ReadLine().Split(" ");
            }

            foreach (string message in chatLog)
            {
                Console.WriteLine(message);
            }
        }
    }
}
