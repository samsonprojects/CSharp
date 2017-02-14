using System;
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

        public override int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public override int Width
        {
            get { return this.Width; }
            set { this.Width = value; }
        }

        public triangle(int H,int W)
        {
            this.height = H;
            this.width = W;
        }

       
        public override void CalculateSurface()
        {
            int Surface = (Height * Width) / 2;
            Console.WriteLine("The Surface is : {0}", Surface);
        }

        static void Main()
        {
            triangle 3Polygon = new triangle(4, 5);
        }

    }
}
