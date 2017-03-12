using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class program
    {
        public static void AbstractFactory()
        {
            CarFactory audiFactory = new AudiFactory();
            Driver driver1 = new FactoryExample.Driver(audiFactory);
            driver1.CompareSpeed();
            
        }

        static void Main()
        {
            AbstractFactory();
            Console.ReadLine();
        }
    }
}
