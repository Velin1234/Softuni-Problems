﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Box_Data
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get { return length; }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Length cannot be zero or negative.");
                }

                length = value;
            }
        }
        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Width cannot be zero or negative.");
                }

                width = value;

            }
        }
        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Height cannot be zero or negative.");
                }

                height = value;
            }
        }
    
        public double SurfaceArea()
        {
            double surfaceArea = 2 * this.length * this.width + 2 * this.length * this.height + 2 * this.height * this.width;
            return surfaceArea;
        }
        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = (2 * this.length + 2 * this.width) * this.height;
            return lateralSurfaceArea;
        }
        public double Volume()
        {
            double volume = this.length*this.width*this.height;
            return volume;
        }
    }
}
