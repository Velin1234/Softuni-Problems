using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyName;

        public List<Person> FamilyName { get => familyName; set => familyName = new List<Person>(); }

        public Family()
        {
            FamilyName = familyName;
        }
        public void AddMember(Person person)
        {
            this.FamilyName.Add(person);
        }

        public string GetOldestMember()
        {
            Person oldestPerson = FamilyName.OrderByDescending(p => p.Age).First();
            return $"{oldestPerson.Name} {oldestPerson.Age}";
        }

    }
}
