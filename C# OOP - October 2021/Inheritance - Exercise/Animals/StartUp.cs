using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string type = Console.ReadLine();
            while (type != "Beast!")
            {
                string[] animalInfo = Console.ReadLine().Split();
                string animalName = animalInfo[0];
                int animalAge = Convert.ToInt32(animalInfo[1]);
                string animalGender = animalInfo[2];
                if (animalAge >= 0)
                {
                    switch (type)
                    {
                        case "Dog":
                            Dog dog = new Dog(animalName, animalAge, animalGender);
                            animals.Add(dog);
                            break;
                        case "Frog":
                            Frog frog = new Frog(animalName, animalAge, animalGender);
                            animals.Add(frog);
                            break;
                        case "Cat":
                            Cat cat = new Cat(animalName, animalAge, animalGender);
                            animals.Add(cat);
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(animalName, animalAge);
                            animals.Add(kitten);
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(animalName, animalAge);
                            animals.Add(tomcat);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                
                type = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
