﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ComputerShop
    {
        public void ConstructComputer(ComputerBuilder computerBuilder)
        {
            computerBuilder.BuildMotherboard();
            computerBuilder.BuildProcessor();
            computerBuilder.BuildHardDisk();
            computerBuilder.BuildScreen();
        }
    }

    public abstract class ComputerBuilder
    {
        public Computer Computer { get; set; }

        public abstract void BuildMotherBoard();
        public abstract void BuildProcessor();
        public abstract void BuildHardDisk();
        public abstract void BuildScreen();
    }
}
