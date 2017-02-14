using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    public class Circle: Shape
    {
        public int width;
        public int height;

        public int Width { get { return this.width; } set { this.width = value; } }
        public int Height { get { return this.height; } set { this.height = value; } }
        public Circle(int H, int W)
        {
            this.height = H;
            this.width = W;
        }

        public override void CalculateSurface()
        {
            int Surface = (Height * Width) / 2;
            Console.WriteLine("The Surface is : {0}", Surface);
        }

        public override void CalculateArea()
        {
            throw new NotImplementedException();
        }

    }
}
