using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools
{
    public class SchoolTest
    {
        static void Main()
        {
            AClass MyClass = new AClass("H11F");
            Teacher teach1 = new Schools.Teacher("Tom", "Walsh");
            Course Computing = new Course("Computing");
            Course Science = new Course("Science");
            teach1.AddCourse(Computing);
            teach1.AddCourse(Science);
            teach1.PrintTeacherProfile();
            Console.ReadLine();

        }
    }
}
