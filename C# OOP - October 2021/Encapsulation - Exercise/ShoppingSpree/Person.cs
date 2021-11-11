using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<string> productsBag;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            ProductsBag = new List<string>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Money
        {
            get => money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public IReadOnlyCollection<string> ProductsBag { get => productsBag; set => productsBag = value.ToList(); }
        public void AddProductToBag(Product product)
        {
            if (product.Cost > this.Money)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
            else
            {
                this.money -= product.Cost;
                productsBag.Add(product.Name);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
        }
        public override string ToString()
        {
            if (productsBag.Count > 0)
            {
                return $"{this.Name} - {string.Join(", ", productsBag)}";
            }
            return $"{this.Name} - Nothing bought";
        }
    }
}
