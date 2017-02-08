using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileAndSortContents
{

    public class Student: IComparable<Student>
    {
        //the Icomparable is defined so we can define the order of elements based
        //on this solution, sort by family name and then first name
        private string firstName;
        private string lastName;

        public Student(string FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }

        public int CompareTo(Student student)
        {
            int result = lastName.CompareTo(student.lastName);
            if(result == 0)
            {
                result = firstName.CompareTo(student.firstName);
            }
            return result;
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }

    }
}
