using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools
{
    public class Teacher :People
    {
        private HashSet<Course> SetOfCourses;


        public int NumberOfCourses
        {
            get { return this.SetOfCourses.Count; }
        }
        public Teacher(string FirstName, string LastName): base(FirstName, LastName)
        {
            this.SetOfCourses =  new HashSet<Course>();
        }



        
        public void AddCourse(Course NewCourse)
        {
           
            this.SetOfCourses.Add(NewCourse);
            Console.WriteLine("Course Added Succesfully");
        }

        public void PrintCourses()
        {
            foreach(Course CourseT in SetOfCourses)
            {
                CourseT.PrintCourseProfile();
            }
        }
        public void PrintTeacherProfile()
        {
            Console.WriteLine("FirstName : {0}", this.FirstName);
            Console.WriteLine("LastName: {0}", this.LastName);
            Console.WriteLine("Number of Courses Teaching", NumberOfCourses);
            Console.WriteLine();
            PrintCourses();
            
        }
    }
}
