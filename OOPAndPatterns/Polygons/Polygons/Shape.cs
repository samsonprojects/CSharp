using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    /// <summary>
    /// Define an abstract class Shape with abstract method CalculateSurface()
    /// and fields width and height
    /// </summary>
    public abstract class Shape
    {
        public abstract void CalculateSurface();

        public abstract void CalculateArea();
        
    }
}
