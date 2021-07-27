using System;

namespace _04.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            // mm,cm,m
            string input_unit = Console.ReadLine();
            string export_unit = Console.ReadLine();
            if (input_unit == export_unit)
            {
                Console.WriteLine($"{value:f3}");
            }
            // mm
            if (input_unit == "mm" && export_unit == "cm")
            {
                value = value / 10;
                Console.WriteLine($"{value:f3}");
            }
            else if (input_unit == "mm" && export_unit == "m")
            {
                value = value / 1000;
                Console.WriteLine($"{value:f3}");
            }
            // cm
            if (input_unit == "cm" && export_unit == "m")
            {
                value = value / 100;
                Console.WriteLine($"{value:f3}");
            }
            else if (input_unit == "cm" && export_unit == "mm")
            {
                value = value * 10;
                Console.WriteLine($"{value:f3}");
            }
            // m
            if (input_unit == "m" && export_unit == "mm")
            {
                value = value * 1000;
                Console.WriteLine($"{value:f3}");
            }
            else if (input_unit == "m" && export_unit == "cm") 
            {
                value = value * 100;
                Console.WriteLine($"{value:f3}");
            }

        }
    }
}
