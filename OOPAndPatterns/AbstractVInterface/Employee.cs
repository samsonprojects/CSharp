using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVInterface
{
    public abstract class Employee
    {
        //we can have fields and properties
        //in the abstract class

        protected String id;
        protected String lname;
        protected String fname;

        //
        public abstract String ID { get; set; }
        public abstract String LastName
        {
            get;set;
        }

        //completed methods
        public String Update()
        {
            return "Employee " + id + " " + lname + " " + fname + "updated";
        }

        public String Add()
        {
            return "Employee " + id + " " + lname + " " + fname + " deleted";
        }

        public String Delete()
        {
            return "Employee " + id + " " + lname + " " + fname + " deleted";
        }

        //completed methods 
        public String Search()
        {
            return "Employee" + id + " " + lname + " " + fname + " found";

        }

        public abstract String CalculateWage();

    }
}
