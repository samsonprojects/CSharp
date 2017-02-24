using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// By using the extension methods OrderBy(…) and ThenBy(…) with lambda expression,
/// sort a list of students by their first and last name in descending order.
/// Rewrite the same functionality using a LINQ query. 
/// </summary>

namespace ConsoleApplication4
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }


    class Program
    {
        static void Main()
        {
            List<Student> Students = new List<Student>()
        {
            new Student {firstName="Rex", lastName="Ryan" },
            new Student {firstName ="Tom", lastName="Tibidoe"},
            new Student { firstName= "Hugh" , lastName="Jackson"}
        };
            var OrderedStudentsInAsc = Students.OrderByDescending(x => x.firstName);
            var OrderedStudentInDesc = Students.OrderByDescending(x => x.lastName);

            //PrintStudents(OrderedStudentInDesc);
            PrintStudentsUsingLinq(Students);
            Console.ReadLine();

        }

        static void PrintStudentsUsingLinq(IEnumerable<Student> StudentList)
        {
            var studentsFiltered =
                from currStudent in StudentList
                orderby currStudent.firstName descending
                select currStudent;

            PrintStudents(studentsFiltered);
        }
        static void PrintStudents(IEnumerable<Student> studentList)
        {
            foreach(var student in studentList)
            {
                Console.WriteLine("FirstName: {0}, Last Name:{1}", student.firstName, student.lastName);
            }

        }
    }
}
