using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */
            var vehicles = new List<Vehicle>();
            var car1 = new Car()
            {
                HasTrunk = true,
                Year = "2021",
                Make = "Chevrolet",
                Model = "Tahoe",
            };
            var moto1 = new Motorcycle() 
            { 
                HasSideCart = true,
                Year = "2017",
                Make = "Suzuki",
                Model = "GSX",
            
            };
            Vehicle veh1 = new Car()
            {
                Year = "2021",
                Make = "GMC",
                Model = "Yulon XL",

            };   
            Vehicle veh2 = new Motorcycle() 
            {
                Make = "Kawasaki", 
                Year = "2015",
                Model = "Ninja",

            };
            vehicles.Add(car1);
            vehicles.Add(moto1);
            vehicles.Add(veh1);
            vehicles.Add(veh2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($" Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model}");
                Console.WriteLine();
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine();
                 

            }


            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            //Console.ReadLine();
        }
    }
}
