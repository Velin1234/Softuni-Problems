using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Citizen:IBuyer
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get => name; private set => name = value; }
        public int Age { get => age; private set => age = value; }
        public string Id { get => id; private set => id = value; }
        public string Birthdate { get => birthdate; private set => birthdate = value; }

        public int BuyFood()
        {
            return 10;
        }
    }
}
