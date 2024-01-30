using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car car = new Car { Year = "2020", Make = "Dogdge" };

            Truck truck = new Truck { Model = "Silverado", HasHood = true };

            SUV suv = new SUV { NumberOfSeats = 7, Space = "Spacious" };

            List<IVehicle> vehicles = new List<IVehicle>();

            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(suv);

            foreach (IVehicle vehicle in vehicles) 
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model}");
                Console.WriteLine();
                vehicle.Drive();
                Console.WriteLine();

            }


        }
    }
}
