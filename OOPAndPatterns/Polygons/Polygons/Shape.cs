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
        protected int width;
        protected int height;

        protected int Width { get; set; }
        protected int Height { get; set; }



        protected abstract void CalculateSurface();
        
        
    }
}
