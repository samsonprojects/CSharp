using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceKingdom
{
    public class AfricanLion: Lion
    {
        public AfricanLion(bool male, int weight): base(male, weight)
        {

        }

        public override string ToString()
        {
            return string.Format("(AfricanLion, male: {0}, weight: {1}", this.Male, this.Weight);
        }

        static void Main()
        {
            AfricanLion Simba = new InheritanceKingdom.AfricanLion(true, 345);
            Console.Write(Simba.ToString());
            Console.ReadLine();
        }
    }
}
