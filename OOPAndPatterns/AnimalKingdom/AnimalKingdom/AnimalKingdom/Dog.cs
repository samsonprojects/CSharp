using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Dog : Animal
    {
        public Dog(string Name, int Age, bool GenderIfMale)
        {
            this.name = Name;
            this.age = Age;
            this.Male = GenderIfMale; // true if male
        }


        protected override string GetTypicalSound()
        {
            return "Woof woof";

        }

    }



}
