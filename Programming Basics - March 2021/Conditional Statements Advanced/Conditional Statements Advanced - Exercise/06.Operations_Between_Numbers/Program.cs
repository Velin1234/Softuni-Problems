using System;

namespace _06.Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = int.Parse(Console.ReadLine());
            double number2 = int.Parse(Console.ReadLine());
            string numeric_operator = Console.ReadLine();
            double result;

            switch (numeric_operator)
            {
                case "+":
                    result = number1 + number2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {numeric_operator} {number2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {numeric_operator} {number2} = {result} - odd");
                    }
                    break;
                
                case "-":
                    result = number1 - number2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {numeric_operator} {number2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {numeric_operator} {number2} = {result} - odd");
                    }
                    break;
                
                case "*":
                    result = number1 * number2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {numeric_operator} {number2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {numeric_operator} {number2} = {result} - odd");
                    }
                    break;
                
                case "/":
                    result = number1 / number2;
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {numeric_operator} {number2} = {result:f2}");
                    }
                    break;
                
                case "%":
                    result = number1 % number2; 
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {numeric_operator} {number2} = {result}");
                    }
                    break;

            }
        }
    }
}
