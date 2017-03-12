using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public abstract class SportsCar
    {

    }

    public abstract class FamilyCar
    {
        public abstract void Speed(SportsCar abstractFamilyCar);
    }

    class MercedesSportsCar: SportsCar
    {
        
    }

    class MercedesFamilyCar : FamilyCar
    {
        public override void Speed(SportsCar abstractSportsCar)
        {
            Console.WriteLine(GetType().Name + " is slower than " 
                + abstractSportsCar.GetType().Name);
        }
    }

    class AudiSportsCar: SportsCar
    {

    }
    class AudiFamilyCar: FamilyCar
    {
        public override void Speed(SportsCar abstractSportsCar)
        {
            Console.WriteLine(GetType().Name + " is slower than " + abstractSportsCar.GetType().Name);
        }
    }
}
