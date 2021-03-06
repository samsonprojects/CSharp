﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    /// <summary>
    /// Define two additional classes for a triangle and a rectangle, which implement CalculateSurface()
    /// </summary>
    public class triangle:Shape
    {
        public int width;
        public int height;

        public int Width { get { return this.width; } set { this.width = value; } }
        public int Height { get { return this.height; } set { this.height = value; } }
        public triangle(int H,int W)
        {
            this.height = H;
            this.width = W;
        }

        public override void CalculateSurface()
        {
            int Surface = (Height * Width) / 2;
            Console.WriteLine("The Surface of this Triangle : {0}", Surface);
        }

        public override void CalculateArea()
        {
            int area = (Width / 2) * Height;
            Console.WriteLine("The Area of the Triangle is {0}", area);
        }

    }
}
