using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
		
		
        public string MilesPerGallon { get; set; }
		public bool IsCoupe { get; set; }

        public int HowManyWheels { get; set; }
        public bool HasEngine { get; set; }
        public string WhatColor { get; set; }
        public bool CanFly { get; set; }

        public string Logo { get; set; }
        public bool IsAmerican { get; set; }

        public void DrivingWhat()
        {
            Console.WriteLine("You are driving a car!");
        }


    }
}

