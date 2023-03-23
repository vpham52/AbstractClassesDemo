using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}

        public override void DriveAbstract()
        {
            Console.WriteLine("Have you heard of lane splitting???!.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Hope you have your helmet!");

        }

        public bool HasSideCar { get; set; }
    }
}

