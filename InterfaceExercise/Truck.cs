using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public string Model { get; set; }
        public bool HasHood {  get; set; }
        public bool HasTrunk { get ; set ; }
        public string Brand { get ; set ; }
        public int NumberOfWheels { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public string Employees { get ; set ; }
        public string Logo { get ; set ; }
        public int Year { get; set; }
        public string Make { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }
        
    }
}
