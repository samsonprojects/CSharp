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
                while (true)
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

                    //Console.WriteLine("{0}-{1}-{2}", course, firstName, lastName);
                }
            }

        }

        public void FileStudents()
        {
            List<Student> students;
            if(!this.Subjects.TryGetValue)
        }
        static void Main()
        {
            CreateFileOfStudents TestCase = new CreateFileOfStudents();
            TestCase.ReadStudenFile();
            Console.ReadLine();
        }
    }
}
