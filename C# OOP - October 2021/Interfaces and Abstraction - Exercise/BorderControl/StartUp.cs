using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Problem 4 List
            //List<IIdentifiable> citizens = new List<IIdentifiable>();
            List<IBirthable> birthables = new List<IBirthable>();
            string[] input = Console.ReadLine().Split(' ');
            while (input[0] != "End")
            {
                //Proble 4 Input
                //if (input.Length == 2)
                //{
                //    Robot robot = new Robot(input[1], input[0]);
                //    citizens.Add(robot);
                //}
                //else if (input.Length == 3)
                //{
                //    Person person = new Person(input[2], input[0], int.Parse(input[1]));
                //    citizens.Add(person);
                //}
                switch (input[0])
                {
                    case "Citizen":
                        string name = input[1];
                        int age = int.Parse(input[2]);
                        string id = input[3];
                        string date = input[4];
                        Person person = new Person(id, name, age, date);
                        birthables.Add(person);
                        break;
                    case "Pet":
                        name = input[1];
                        date = input[2];
                        Pet pet = new Pet(name, date);
                        birthables.Add(pet);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split(' ');
            }
            string year = Console.ReadLine();
            foreach (var birthCitz in birthables)
            {
                if (birthCitz.Birthdate.EndsWith(year))
                {
                    Console.WriteLine(birthCitz.Birthdate);
                }
            }

            //Problem 4 Validation
            //int lastFakeDigits = int.Parse(Console.ReadLine());
            //foreach (var citizen in citizens)
            //{
            //    string citizenId = citizen.Id;
            //    if (citizenId.EndsWith(lastFakeDigits.ToString()))
            //    {
            //        Console.WriteLine(citizenId);
            //    }
            //}
        }
    }
}
