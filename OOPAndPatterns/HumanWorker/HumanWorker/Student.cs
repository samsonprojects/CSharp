using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWorker
{
    public class Student :Human,IComparable
    {
        private int Mark;

        public int GetNSetMark
        {
            get { return this.Mark; }
        }

     

        public Student(string firstName , string lastName,int Mark): base(firstName, lastName)
        {
            this.Mark= Mark;
            

        }

        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                return 1;
            }
            Student OtherStudent = obj as Student;
            if(OtherStudent != null)
            {
                return this.Mark.CompareTo(OtherStudent.GetNSetMark);

            }
            else
            {
                throw new ArgumentException("Object is not a Mark");
            }
        }

        /// <summary>
        /// Test cases below for both worker and student class
        /// both class derive from the human class
        /// </summary>
        static void Main()
        {
            Student Boris = new HumanWorker.Student("Kojo", "Funds", 60);
            Console.Write(Boris.ToString());

            Console.WriteLine();
            Worker Nigel = new Worker("Nigel", "Bojangle", 50000, 24000);
            Console.WriteLine(Nigel.ToString());
            Nigel.HourlyWage();


            List<Student> StudentsList = new List<Student>();
            //initialise random generator
            Random rnd = new Random();

            //Generate 10 students and student marks between 1 and 100.

            for(int stuNum=1; stuNum <= 10; stuNum++)
            {
                int StudentMark = rnd.Next(0, 100);
                Student temp = new Student("Uknown"+StudentMark.ToString(), "Uknown Sur",StudentMark);
                StudentsList.Add(temp);
            }

            //Sort Arraylist
            StudentsList.Sort();
            foreach(Student temp in StudentsList)
            {
                Console.WriteLine("{0}: {1}",temp.GetFirstName,temp.GetNSetMark);

            }


            Console.ReadLine();


        }
    }
}
