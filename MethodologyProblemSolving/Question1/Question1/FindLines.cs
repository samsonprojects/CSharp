using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public enum Axis { verticle, horizontal}
    public class FindLines
    {
        //coordinates are a list of points
        List<Point> coordinates = new List<Point>();
        Dictionary<Axis, List<Point>> FoundLines = new Dictionary<Axis, List<Point>>();
        
        /// <summary>
        /// Generate random test inputs
        /// </summary>
        public void CreateSeedData()
        {
            coordinates.Add(new Point() { X = 9, Y=10 });
            coordinates.Add(new Point() { X = 8, Y = 7 });
            coordinates.Add(new Point() { X = 7, Y = 8 });
            coordinates.Add(new Point() { X = 2, Y = 5 });
            coordinates.Add(new Point() { X = 6, Y = 9 });
            coordinates.Add(new Point() { X = 0, Y = 19 });
            PrintPoints(this.coordinates);
            FilterCoordinates(this.coordinates);
            
        }


        //using 
        public Dictionary<Axis,List<Point>> FilterCoordinates(List<Point> Coordinates)
        {
            List<Point> verticle = new List<Point>();
            List<Point> horizontal = new List<Point>();
            for(int i =0; i<Coordinates.Count; i++)
            {
                if(Coordinates[i].X !=0 && Coordinates[i].Y != 0)  //Line not 
                {
                    if (Coordinates[i].X > Coordinates[i].Y)
                    {
                        horizontal.Add(Coordinates[i]);
                    }
                    if (Coordinates[i].Y > Coordinates[i].X)
                    {
                        verticle.Add(Coordinates[i]);
                    }
                }

            }
            FoundLines.Add(Axis.horizontal, horizontal);
            FoundLines.Add(Axis.verticle, verticle);
            return FoundLines;
        }

        public void PrintLines()
        {
            
            foreach(KeyValuePair<Axis,List<Point>> cood in FoundLines)
            {
                Console.WriteLine("{0} Axis is:",cood.Key);
                foreach(Point p in cood.Value)
                {
                    Console.Write(" ({0},{1}) ", p.X, p.Y);
                }
                Console.WriteLine();
            }
        }
        public void PrintPoints(List<Point> Coordinates)
        {
            foreach (Point p in Coordinates)
            {
                Console.WriteLine("X axis is: {0}, Y axis is:{1}", p.X, p.Y);
                
            }
            Console.WriteLine();
        }
        public FindLines() {
            CreateSeedData();
        }

        static void Main()
        {
            FindLines t1 = new FindLines();
            t1.PrintLines();
            Console.ReadLine();

        }

        
        
    }
}
