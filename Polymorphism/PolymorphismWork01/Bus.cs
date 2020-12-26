using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, int tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
