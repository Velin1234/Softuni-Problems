using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel:IBuyer
    {
        private string name;
        private int age;
        private string groupName;

        public Rebel(string name, int age, string groupName)
        {
            Name = name;
            Age = age;
            GroupName = groupName;
        }

        public string Name { get => name;private set => name = value; }
        public int Age { get => age;private set => age = value; }
        public string GroupName { get => groupName;private set => groupName = value; }

        public int BuyFood()
        {
            return 5;
        }
    }
}
