using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Person : IIdentifiable,IBirthable
    {
        private string id;
        private string name;
        private int age;
        private string birthdate;

        public Person(string id, string name, int age, string birthdate)
        {
            Id = id;
            Name = name;
            Age = age;
            Birthdate = birthdate;
        }

        public string Id { get => id; private set => id = value; }
        public string Name { get => name; private set => name = value; }
        public int Age { get => age; private set => age = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
    }
}
