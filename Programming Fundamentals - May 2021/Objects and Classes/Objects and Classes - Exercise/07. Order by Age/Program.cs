using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public Person(string name, int id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            string personStr = $"{Name} with ID: {ID} is {Age} years old.";
            return personStr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            List<Person> people = new List<Person>();
            while (input[0] != "End")
            {
                Person person = new Person(input[0], Convert.ToInt32(input[1]), Convert.ToInt32(input[2]));
                people.Add(person);
                input = Console.ReadLine().Split(" ");
            }

            List<Person> orderedPeople = new List<Person>();
            orderedPeople = people.OrderBy(p => p.Age).ToList();

            foreach (Person person in orderedPeople)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
