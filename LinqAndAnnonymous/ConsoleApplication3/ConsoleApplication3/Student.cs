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
            this.Age = Age;
        }
       
    }
}
