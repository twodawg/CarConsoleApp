using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarConsoleApp.Models
{
    class Car
    {
        private List<string> _passengers;

        public Car(string pModel, int pDoors)
        {
            Model = pModel;
            Doors = pDoors;

            _passengers = new List<string>();
        }
        public string Model { get; set; }

        public int Doors { get; set; }

        public int EngineCubicCapacity
        {
            get
            {
                return 200;
            }
        }
        public override string ToString()
        {
            return EngineCubicCapacity.ToString();
        }

        public List<string> Passengers
        {
            get
            {
                return _passengers;
            }
        }
    }
}
