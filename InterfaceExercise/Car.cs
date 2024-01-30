using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get ; set ; }
        public string Brand { get ; set ; }
        public int NumberOfWheels { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public string Employees { get ; set ; }
        public string Logo { get ; set ; }
        public int Year { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }

        public void Drive() 
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }
    }
}
