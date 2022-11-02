using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {

        public string Year { get; set; } = "genYear";
        public string Make { get; set; } = "genMake";
        public string Model { get; set; } = "genModel";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
                Console.WriteLine("default virtual drive");
        }


    }
}
