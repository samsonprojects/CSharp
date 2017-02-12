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

        
    }
}
