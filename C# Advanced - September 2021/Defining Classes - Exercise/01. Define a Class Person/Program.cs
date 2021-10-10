using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                int age = Convert.ToInt32(personInfo[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }

            family.FamilyName.Where(m => m.Age > 30).OrderBy(m => m.Name).ToList().ForEach(Console.WriteLine);

        }
    }
}
