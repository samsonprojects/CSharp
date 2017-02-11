using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools
{
    public class Student: People
    {
        private double ID;

        //within the list the id will be set , but it wont be set within the constructor
        public double GetNSetID
        {
            get { return this.ID; }
            set { this.ID = value; }
        }


            

        public Student(string firstName, string lastName): base(firstName, lastName)
        {
            //this.ID;
            string FullName = firstName + lastName;
            Console.WriteLine("ID is : {0}",FullName.GetHashCode());
            double NameID = FullName.GetHashCode();
            this.ID = NameID;
            
        }
        //static void Main()
        //{
        //    Student Tester = new Schools.Student("boomer", "Sorencon");
        //    Console.WriteLine(Tester.ToString());
        //    Console.WriteLine(Tester.GetNSetID);
        //    Console.ReadLine();
        //}

       
    }
}
