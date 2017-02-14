using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    class TestAnimalCases
    {
        static void TestKittens()
        {
            
        }
       
        static void Main()
        {
            List<object> Tests = new List<object>();

            Cat petry = new Cat("Petry", 9, true);
            petry.MakeSound();
            Dog Menace = new AnimalKingdom.Dog("Menace", 2, true);
            Menace.MakeSound();
            Frog toad = new AnimalKingdom.Frog("toad", 1, false);
            toad.MakeSound();
            Kitten babyKit = new AnimalKingdom.Kitten("bobo", 1, false);
            babyKit.MakeSound();
            TomCat tomas = new TomCat("tomas", 3, true);
            tomas.MakeSound();

            Tests.Add(petry);
            Tests.Add(Menace);
            Console.ReadLine();
        }

    }
}
