using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Product> productsToSell = new List<Product>();
            List<Person> peopleInShop = new List<Person>();

            try
            {
                string[] people = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                foreach (var person in people)
                {
                    string[] personInfo = person.Split('=');
                    string name = personInfo[0];
                    decimal money = decimal.Parse(personInfo[1]);

                    Person personInShop = new Person(name, money);
                    peopleInShop.Add(personInShop);
                }

                string[] products = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                foreach (var product in products)
                {
                    string[] productInfo = product.Split('=');
                    string name = productInfo[0];
                    decimal cost = decimal.Parse(productInfo[1]);

                    Product productToSell = new Product(name, cost);
                    productsToSell.Add(productToSell);
                }


                string[] customerInput = Console.ReadLine().Split(" ");
                while (customerInput[0] != "END")
                {
                    string customerName = customerInput[0];
                    string productName = customerInput[1];
                    Product product = productsToSell.Where(p => p.Name == productName).FirstOrDefault();
                    foreach (var person in peopleInShop)
                    {
                        if (person.Name == customerName)
                        {
                            person.AddProductToBag(product);
                        }
                    }
                    customerInput = Console.ReadLine().Split(" ");
                }

                foreach (var customer in peopleInShop)
                {
                    Console.WriteLine(customer);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

