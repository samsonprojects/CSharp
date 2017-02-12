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

        public Worker(string FirstName,string LastName,int Wage,int HoursWorked) : base(FirstName, LastName)
        {
            this.wage = Wage;
            this.HoursWorked = HoursWorked;
        }

        public void HourlyWage()
        {
            Console.WriteLine("Hourly wage is {0}", GetHourRate);
        }
       
    }
}
