using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }

        public override string ToString()
        {
            return $"{this.GetType().Name}\n" +
                $"{this.Name} {this.Age} {this.Gender}\n" +
                $"{ProduceSound()}";
        }

        public virtual string ProduceSound()
        {
            return "...";
        }
    }
}
