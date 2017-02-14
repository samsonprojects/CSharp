using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    class ShapesTest
    {
        static void Main()
        {
            triangle polygonCase1 = new triangle(4, 5);
            polygonCase1.CalculateSurface();
            
            rectangle polygonCase2 = new Polygons.rectangle(9, 2);
            polygonCase2.CalculateSurface();


            Console.ReadLine();
        }
    }
}
