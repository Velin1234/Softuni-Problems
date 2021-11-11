using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                if (value.Length < 3)
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                if (value.Length < 3)
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
        }
        public int Age
        {
            get => age;
            set
            {
                age = value;
                if (value <= 0)
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
        }
        public decimal Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                //if (value < 650)
                //    throw new ArgumentException("Salary cannot be less than 650 leva!");
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            decimal salaryIncrease = this.Salary * percentage / 100;
            if (this.Age < 30)
            {
                salaryIncrease /= 2;
                Salary += salaryIncrease;
            }
            else
            {
                Salary += salaryIncrease;
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }
}
