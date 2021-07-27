using System;

namespace _07.House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            double x_house_height = double.Parse(Console.ReadLine());
            double y_house_lenght = double.Parse(Console.ReadLine());
            double z_roof_height = double.Parse(Console.ReadLine());
            //House math 
            double side_wall = x_house_height * y_house_lenght;
            double window_area = Math.Pow(1.5, 2);
            double both_side_walls = 2 * side_wall - 2 * window_area;
            double back_wall = Math.Pow(x_house_height, 2);
            double entrance = 1.2 * 2;
            double both_front_and_back_walls = 2 * back_wall - entrance;
            //House area & Paint needed
            double house_area = both_side_walls + both_front_and_back_walls;
            double green_paint = house_area / 3.4;
            //Roof Math
            double roof_rectangles = 2 * (x_house_height * y_house_lenght);
            double roof_triangles = 2 * (x_house_height * z_roof_height / 2);
            //Roof area & Paint needed            
            double roof_area = roof_rectangles + roof_triangles;
            double red_paint = roof_area / 4.3; 
            //Print out
            Console.WriteLine($"{green_paint:f2}");
            Console.WriteLine($"{red_paint:f2}");
        }
    }
}
