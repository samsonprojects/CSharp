using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWorker
{
    public class TestCases
    {
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

            for (int stuNum = 1; stuNum <= 10; stuNum++)
            {
                int StudentMark = rnd.Next(0, 100);
                Student temp = new Student("Uknown" + StudentMark.ToString(), "Uknown Sur", StudentMark);
                StudentsList.Add(temp);
            }

            //Sort student Arraylist
            StudentsList.Sort();
            foreach (Student temp in StudentsList)
            {
                Console.WriteLine("{0}: {1}", temp.GetFirstName, temp.GetNSetMark);

            }


            Console.WriteLine("Workers section");
            //Generate 10 workers 
            List<Worker> WorkersList = new List<Worker>();
            for (int workerNum =1; workerNum<=10; workerNum++)
            {
                int workerWage = rnd.Next(0, 5000);
                int Hours = rnd.Next(1, 34000);
                Worker temp = new Worker("Uknown" + workerWage.ToString(), "uknown", workerWage, Hours);
                WorkersList.Add(temp);
            }

            //sort WorkerArray List in descending order
            WorkersList.Sort();
            WorkersList.Reverse();

            foreach(Worker tmp in WorkersList)
            {
                Console.WriteLine("{0} : {1}", tmp.GetFirstName, tmp.Wage);
            }


            Console.ReadLine();


        }
    }
}
