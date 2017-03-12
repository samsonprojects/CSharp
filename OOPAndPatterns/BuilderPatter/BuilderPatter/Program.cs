using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        private static void Builder()
        {
            ComputerShop computerShop = new ComputerShop();
            ComputerBuilder computerBuilder;

            computerBuilder = new LaptopBuilder();
            computerShop.ConstructComputer(computerBuilder);
            computerBuilder.Computer.DisplayConfiguration();

            computerBuilder = new DesktopBuilder();
            computerShop.ConstructComputer(computerBuilder);
            computerBuilder.Computer.DisplayConfiguration();

            computerBuilder = new AppleBuilder();
            computerShop.ConstructComputer(computerBuilder);
            computerBuilder.Computer.DisplayConfiguration();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Builder();
            Console.ReadLine();
        }
    }
}
