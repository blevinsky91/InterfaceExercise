using System;
using System.Collections.Generic;
namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IVehicle> list = new List<IVehicle>();
            List<ICompany> list2 = new List<ICompany>();


            Car car1 = new Car();

            car1.MilesPerGallon = "30 mpg";
            car1.IsCoupe = true;
            car1.HowManyWheels = 4;
            car1.HasEngine = true;
            car1.WhatColor = "blue";
            car1.CanFly = false;
            car1.Logo = "bow-tie";
            car1.IsAmerican = true;

            Truck truck1 = new Truck();

            truck1.BedLength = "6 foot";
            truck1.BedWidth = "80 inches";
            truck1.HowManyWheels = 4;
            truck1.HasEngine = true;
            truck1.WhatColor = "green";
            truck1.CanFly = false;
            truck1.Logo = "ram";
            truck1.IsAmerican = true;

            SUV suv1 = new SUV();

            suv1.CargoSpace = "plenty";
            suv1.RowsOfSeats = 4;
            suv1.HowManyWheels = 4;
            suv1.HasEngine = true;
            suv1.WhatColor = "black";
            suv1.CanFly = false;
            suv1.Logo = "4 rings";
            suv1.IsAmerican = false;

            list.Add(car1);
            list.Add(truck1);
            list.Add(suv1);

            list2.Add(car1);
            list2.Add(truck1);
            list2.Add(suv1);

            foreach (IVehicle item in list)
            {
                Console.WriteLine($"You are driving a vehicle that is {item.WhatColor} in color and has {item.HowManyWheels} wheels!");

            }

            foreach (ICompany item in list2)
            {
                Console.WriteLine($"You are driving a vehicle that has a {item.Logo} logo!");
            }

            
            

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - DONE

            //Create 3 classes called Car , Truck , & SUV - DONE

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common. -DONE
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company - DONE
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes - DONE

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
