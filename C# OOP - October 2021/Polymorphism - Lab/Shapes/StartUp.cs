using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rectange = new Rectangle(10,20);
            Shape circle = new Circle(10);
            Console.WriteLine(rectange.CalculatePerimeter());
            Console.WriteLine(rectange.CalculateArea());
            Console.WriteLine(rectange.Draw());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.Draw());
        }
    }
}
