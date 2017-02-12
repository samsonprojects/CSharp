using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWorker
{
    public class Student :Human
    {
        private int Mark;

        public Student(string firstName , string lastName,int Mark): base(firstName, lastName)
        {
            this.Mark= Mark;
            

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
            Console.ReadLine();
        }
    }
}
