using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Dog
    {

        public string Name { get; set; }
        public int Age { get; set; }

        static void Main()
        {
            List<Dog> dogs = new List<Dog>()
        {
            new Dog { Name="Rex", Age=4},
            new Dog { Name="Sean",Age=0},
            new Dog { Name="Stacey", Age=3}
        };

            var names = dogs.Select(x => x.Name);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }

    }

   
}
