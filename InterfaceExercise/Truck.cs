using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		
		
	    public string BedLength { get; set; }
		public string BedWidth { get; set; }

        public int HowManyWheels { get; set; }
        public bool HasEngine { get; set; }
        public string WhatColor { get; set; }
        public bool CanFly { get; set; }

        public string Logo { get; set; }
        public bool IsAmerican { get; set; }


        public void DrivingWhat()
        {
            Console.WriteLine("You are driving a truck!");
        }

    }
}

