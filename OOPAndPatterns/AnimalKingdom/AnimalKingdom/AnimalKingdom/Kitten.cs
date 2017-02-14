using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{

    public class Kitten : Animal
    {
        public Kitten(string Name, int Age, bool Male)
        {
            this.name = Name;
            this.age = Age;
            this.Male = Male;

        }

        protected override string GetTypicalSound()
        {
            return " baby meow baby meow";
        }
    }
}
