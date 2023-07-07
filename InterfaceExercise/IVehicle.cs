using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int HowManyWheels { get; set; }
		public bool HasEngine { get; set; }
		public string WhatColor { get; set; }
		public bool CanFly { get; set; }
	}
}

