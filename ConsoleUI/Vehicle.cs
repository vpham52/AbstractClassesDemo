using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public Vehicle()
		{
		}

		public int numberOfTires = 4;
		public string numberOfDoors = "4";
		public int numberOfSeats = 5;
		public bool hasSunroof = false;

		public string Year { get; set; } = "2000";
		public string Make { get; set; } = "Default Make";
		public string Model { get; set; } = "Default Model";

		public abstract void DriveAbstract();

		public virtual void DriveVirtual()
		{
			Console.WriteLine("Grateful to have a mode of transportation!");
		}

		

		

		


	}
}

