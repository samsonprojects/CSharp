using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a class Student with the following properties: 
/// first name, last name and age. Write a method that for a given array of students finds those,
/// whose first name is before their last one in alphabetical order.
/// Use LINQ.
/// </summary>

namespace ConsoleApplication3
{
    class Student
    {

        public string Name {get;set;}

        public string lastName { get; set; }

        public int Age { get; set; }

        public Student():this("Unknown" , "Uknowns LastName")
        {

        }
        public Student(string Name, string lastName):this(Name,lastName,21)
        {
            

        }

        public Student(string Name, string lastName, int Age)
        {
            this.Name = Name;
            this.lastName = lastName;
        }
        static void Main(string[] args)
        {

            Student Boris = new ConsoleApplication3.Student();
            //Boris.Age = 9;
            //Boris.Name = "Andrew";
            Console.WriteLine(Boris.Name);
            SortSample();
            Console.ReadLine();
        }

        //write a method that for a given array of students finds those,
        /// whose first name is before their last one in alphabetical order.
        static void SortSample()
        {
            List<Student> School = new List<Student>() {

                 new Student("member1","zember1LastName"),
                 new Student("Anne", "WitterLastName"),
                 new Student("Soccerman" , "Figo",78)
            };

            ///Linq query : foreach student in school array , find student whose first name is alphabetically before lastname
            var StudentsWithFirst = from student in School
                                                  where student.Name[0] < student.lastName[0]
                                                  select student;

            foreach(var item in StudentsWithFirst)
            {
                Console.WriteLine();
                Console.WriteLine(item.Name + " " + item.lastName);
            }

            
        }
    }
}
