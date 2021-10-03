using System;
using System.Collections.Generic;


namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people.Add(input[0], int.Parse(input[1]));
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Dictionary<string, int> newPeople = new Dictionary<string, int>();

            switch (condition)
            {
                case "older":
                    foreach (var person in people)
                    {
                        if (person.Value >= age)
                        {
                            newPeople.Add(person.Key, person.Value);
                        }
                    }
                    break;
                case "younger":
                    foreach (var person in people)
                    {
                        if (person.Value <= age)
                        {
                            newPeople.Add(person.Key, person.Value);
                        }
                    }
                    break;
            }

            string format = Console.ReadLine();
            switch (format)
            {
                case "name":
                    foreach (var name in newPeople)
                    {
                        Console.WriteLine($"{name.Key}");
                    }
                    break;

                case "age":
                    foreach (var name in newPeople)
                    {
                        Console.WriteLine($"{name.Value}");
                    }
                    break;

                case "name age":
                    foreach (var name in newPeople)
                    {
                        Console.WriteLine($"{name.Key} - {name.Value}");
                    }
                    break;
            }
        }
    }
}
