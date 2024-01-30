using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public int NumberOfSeats { get; set; }
        public string Space  { get; set; }
        public bool HasTrunk { get; set; }
        public string Brand { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string Employees { get; set; }
        public string Logo { get; set; }
        public object Year { get ; set ; }
        public object Make { get ; set ; }
        public object Model { get ; set ; }

        public void Drive()
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }
    }
}
