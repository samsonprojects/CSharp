using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWorker
{
    public class Worker: Human
    {
        private int wage;

        private int HoursWorked;

        public int GetHourRate
        {
            get { return this.wage / this.HoursWorked; }
        }

        /// <summary>
        /// Constructor initialises the base classes  
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Wage"></param>
        /// <param name="HoursWorked"></param>
        public Worker(string FirstName,string LastName,int Wage,int HoursWorked) : base(FirstName, LastName)
        {
            this.wage = Wage;
            this.HoursWorked = HoursWorked;
        }

        /// <summary>
        /// Hourly rate divides the the yearly wage by the hours worked
        /// /// <param name="Wage"></param>
        /// <param name="HoursWorked"></param>
        /// </summary>
        public void HourlyWage()
        {
            Console.WriteLine("Hourly wage is {0}", GetHourRate);
        }
       
    }
}
