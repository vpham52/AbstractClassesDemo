using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle -- DONE
             * The vehicle class shall have three string properties Year, Make, and Model-- DONE
             * Set the defaults to something generic in the Vehicle class -- DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation -- DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle -- DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle -- DONE
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of
             * type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            var audi = new Car()
            {
                Year = "2021",
                Make = "Audi",
                Model = "R8",
                HasTrunk = false,

                numberOfTires = 4,
                numberOfDoors = "2",
                            
            };

            vehicles.Add(audi);


            var harley = new Motorcycle()
            {
                Year = "1957",
                Make = "Harley",
                Model = "Sportster",
                HasSideCar = true,

                numberOfTires = 2,
                numberOfDoors = "none, it's a bike!",

            };
            vehicles.Add(harley);

            //Explicit typing
            Vehicle mercedes = new Car()

            {
                Year = "2023",
                Make = "Mercedes",
                Model = "G-Wagon",
                HasTrunk = true,

                numberOfTires = 4,
                numberOfDoors = "4",

            };
            vehicles.Add(mercedes);

            Vehicle bmwBike = new Motorcycle()
            {
                Year = "1923",
                Make = "BMW",
                Model = "R32",
                HasSideCar = false,

                numberOfTires = 4,
                numberOfDoors = "none, it's a bike!",

            };
            vehicles.Add(bmwBike);



            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.GetType().Name}\n{item.Year} {item.Make} {item.Model}\n" +
                    $"Number of doors: {item.numberOfDoors}\nNumber of Tires: {item.numberOfTires}\n");

                item.DriveAbstract();
                item.DriveVirtual();

                //item.DriveAbstract();
                Console.WriteLine("----------------------------");
            }

                


           


            #endregion
            Console.ReadLine();
        }
    }
}
