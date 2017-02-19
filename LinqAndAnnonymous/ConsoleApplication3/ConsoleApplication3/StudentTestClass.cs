using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class StudentTestClass
    {
        static void Main()
        {
            List<Student> School = new List<Student>() {

                 new Student("member1","zember1LastName"),
                 new Student("Anne", "WitterLastName",18),
                 new Student("Soccerman" , "Figo",23),
                 new Student ("Cesar", "Garcia", 29),
                 new Student ("Sven", "Mortensen",24)
            };

            
            SortSample(School);
            FindWithinAge(School);
            Console.ReadLine();
        }

        //write a method that for a given array of students finds those,
        /// whose first name is before their last one in alphabetical order.
        static void SortSample(List<Student> School)
        {
            ///Linq query : foreach student in school array , find student whose first name is alphabetically before lastname
            var StudentsWithFirst = from student in School
                                    where student.Name[0] < student.lastName[0]
                                    select student;

            foreach (var item in StudentsWithFirst)
            {
                Console.WriteLine();
                Console.WriteLine(item.Name + " " + item.lastName);
            }


        }

        /// <summary>
        /// Create a LINQ query that finds the first and the last name of all students, 
        /// aged between 18 and 24 years including. 
        /// Use the class Student from the previous exercise.
        /// </summary>
        static void FindWithinAge(List<Student> StudentList)
        {
            var StudentsFirstAndLast = from student in StudentList
                                       where student.Age > 17 && student.Age < 24
                                       select student;

            foreach (var item in StudentsFirstAndLast)
            {
                Console.WriteLine("Student name:  {0} , Last Name: {1}", item.Name, item.lastName);
            }

        }
    }
}
