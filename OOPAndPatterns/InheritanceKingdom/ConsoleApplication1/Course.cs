using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools
{
    /// <summary>
    /// Courses have a name, count of classes and count of exercises.
    /// </summary>
    public class Course
    {
        private List<AClass> ListOfClasses = new List<AClass>();

        private string CourseName;
        private int CountOfExcersises;
        private int CountOfClasses = 0;

        public int CountListOfClasses
        {
            get { return ListOfClasses.Count(); }
        }

        public int NumberOfExcersises
        {
            get { return this.CountOfExcersises; }
        }

        public int NumberOfTaughtClasses
        {
            get { return this.CountOfClasses; }
        }

        public string GetCourseName
        {
            get { return this.CourseName; }
        }
        public Course(string name)
        {
            this.CourseName = name;

        }

        public void AddNewClass(AClass newClass)
        {
            this.ListOfClasses.Add(newClass);
            this.CountOfClasses = this.ListOfClasses.Count();
        }

        public void PrintCourseProfile()
        {
            Console.WriteLine("Course Name: {0}", GetCourseName);
            Console.WriteLine("Number of Excersises:  {0}", NumberOfExcersises);
            Console.WriteLine("Number of Taught Classes:  {0}", NumberOfTaughtClasses);
        }
        
        
    }
}
