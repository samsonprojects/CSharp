using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Frog : Animal
    {
        public Frog(string Name, int Age, bool Male)
        {
            this.name = Name;
            this.age = Age;
            this.Male = Male;
        }

        protected override string GetTypicalSound()
        {
            return "bebep bebep";
        }
    }
}
