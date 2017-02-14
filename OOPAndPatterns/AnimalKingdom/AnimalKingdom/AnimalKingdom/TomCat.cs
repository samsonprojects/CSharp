using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class TomCat: Cat
    {
        public TomCat(string name,int Age, bool Male):base (name,Age,Male)
        {

        }

        protected override string GetTypicalSound()
        {
            return "yahooow";
        }
    }
}
