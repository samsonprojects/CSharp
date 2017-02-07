using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSortSolution
{
    public class SortStudentsWithDict
    {
        static void Main()
        {
            //Read the file and build the hash-table of the courses
            Dictionary<string, List<Student>> courses =
                new Dictionary<string, List<Student>>();

          string InFile = @"..\..\MyStudents.txt";
        StreamReader reader = new StreamReader(InFile);
            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if(line == null)
                    {
                        break;
                    }
                    string[] entry = line.Split(new char[] { '|' });
                    string firstName = entry[0].Trim();
                    string lastName = entry[1].Trim();
                    string course = entry[2].Trim();
                    List<Student> students;
                    if(! courses.TryGetValue(course, out students)) //see if key value pair exists
                    {
                        //New course -> create a list of students for it
                        students = new List<Student>();
                        courses.Add(course, students);
                    }

                    //create  a student class
                    Student student = new Student(firstName, lastName);
                    students.Add(student);//add the student to the dictionary key value match

                }
            }

            //Print the courses and their students
            foreach(string course in courses.Keys)
            {
                Console.WriteLine("Course " + course + ":");
                List<Student> students = courses[course]; //gets the value of the key, which is a string
                students.Sort();
                foreach (Student student in students)//iterate throgh list to obtain instances of students
                {
                    Console.WriteLine("\t{0}", student);
                }
            }
            Console.ReadLine();

        }

    }
}
