using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceKingdom
{
    public class Lion : Felidae
    {
        private int weight;

        //Keyword "base"
        public Lion(bool male, int weight): base(male)
        {
            
            this.weight = weight;
        }

        public int Weight
        {
            get { return weight; }
            set { this.weight = value; }
        }
    }
}
