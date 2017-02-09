using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiDictionary
{
    public class TestSolution
    {
        static void Main()
        {
            TripleValues<int> TestCase1 =
                 new TripleValues<int>("Football", "Arsenal", 1);

            TestCase1.AddTriple("Soccer", "LAGalaxy", 2);
            TestCase1.SearchByKey1("Football");
            Console.ReadLine();
        }
    }
}
