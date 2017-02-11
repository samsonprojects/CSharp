using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools
{
    public class People
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return this.firstName; }

        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public People(string FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }



        public override string ToString()
        {
            return string.Format("Persons First Name is: {0}, Surname:{1}", this.firstName, this.lastName);
        }
    }
}
