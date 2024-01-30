using InterfaceExercise;
using System;
using System.Collections.Generic;

Car car = new Car { Year = 2020, Make = "Dodge", Model = "Ram" };

Truck truck = new Truck { Year = 2010, Make = "Chevy", Model = "Tahoe", HasHood = true };

SUV suv = new SUV { Year = 2015, Make = "Range Rover", Model = "A-class" };

List<IVehicle> vehicles = new List<IVehicle>();

vehicles.Add(car);
vehicles.Add(truck);
vehicles.Add(suv);

foreach (IVehicle vehicle in vehicles)
{
    Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model}");
    Console.WriteLine();
    vehicle.Drive();
    vehicle.DriveDefault();
    Console.WriteLine();

}
