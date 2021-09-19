using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            while (songs.Count > 0)
            {
                List<string> input = Console.ReadLine().Split(" ").ToList();
                switch (input[0])
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string song = "";
                        for (int i = 1; i < input.Count; i++)
                        {
                            song += input[i] + " ";
                        }
                        song = song.Trim();
                        if (songs.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(song);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",songs));
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
