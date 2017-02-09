using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFileAndSortContents
{
    public class CreateFileOfStudents
    {
        private const string StudentFile = @"..\..\Students.txt";
        private SortedDictionary<string, List<Student>> Subjects =
            new SortedDictionary<string, List<Student>>();

        public CreateFileOfStudents()
        {
            
        }

        public void ReadStudenFile()
        {
            StreamReader reader = new StreamReader(StudentFile);
            using (reader)
            {
                string Line;
                while (true)//while no exception 
                {
                    Line = reader.ReadLine();
                    if (Line == null)
                    {
                        break;
                    }
                    string[] entry = Line.Split(new char[] { '|' });
                    string fullName = entry[0].Trim();
                    string firstName = fullName.Split(' ')[0];
                    string lastName = fullName.Split(' ')[1];
                    string course = entry[1].Trim();
                    FileStudents(course, firstName, lastName);
                    //Console.WriteLine("{0}-{1}-{2}", course, firstName, lastName);
                }
            }

        }
        /// <summary>
        /// CHeck whether the key course is in the sorted dictionary, 
        /// if not create a new key value with a value of list<Students>
        /// </summary>
        /// <param name="course"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>

        public void FileStudents(string course,string firstName,string lastName)
        {
            List<Student> students;
            if (!this.Subjects.TryGetValue(course, out students))
            {
                //if no value can be found for the given course key
                //if false create a list of students
                students = new List<Student>();
                this.Subjects.Add(course, students);
            }
            Student student = new Student(firstName, lastName);
            students.Add(student);
        }

        public void PrintFile()
        {
            foreach(string subject in this.Subjects.Keys)
            {
                Console.Write("{0}: ", subject);
                List<Student> students = Subjects[subject];
                students.Sort();
                foreach(Student student in students)
                {
                    Console.Write("  {0},", student);
                }
                Console.WriteLine();

            }
        }
        static void Main()
        {
            CreateFileOfStudents TestCase = new CreateFileOfStudents();
            TestCase.ReadStudenFile();
            TestCase.PrintFile();
            Console.ReadLine();
        }
    }
}
