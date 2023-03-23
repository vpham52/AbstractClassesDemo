using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		public Car()
		{
		}

     
        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Cars are safer than motorcycles -- but don't look as cool.");
           
        }

       
    }
}

