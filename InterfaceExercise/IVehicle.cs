using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public bool HasTrunk { get; set; }
        public string Brand { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        object Year { get; set; }
        object Make { get; set; }
        object Model { get; set; }

        void Drive();
        void DriveDefault() 
        {
            System.Console.WriteLine();
        }
    }
}
