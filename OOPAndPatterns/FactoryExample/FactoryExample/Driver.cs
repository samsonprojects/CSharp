using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class Driver
    {
        private SportsCar _sportsCar;
        private FamilyCar _familyCar;

        public Driver(CarFactory carFactory)
        {
            _sportsCar = carFactory.CreateSportsCar();
            _familyCar = carFactory.CreateFamilyCar();
        }

        public void CompareSpeed()
        {
            _familyCar.Speed(_sportsCar);
        }
    }
}
