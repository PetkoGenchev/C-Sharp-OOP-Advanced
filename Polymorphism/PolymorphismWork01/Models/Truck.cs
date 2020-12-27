using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Contracts;

namespace Vehicles
{
    public class Truck : Vehicle, ITruck
    {

        private const double truckConsumptionIncrease = 1.6;
        private const double truckFuelDecrease = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, int tankCapacity) 
            : base(fuelQuantity, fuelConsumption+truckConsumptionIncrease, tankCapacity)
        {

        }

        public override void Refuel(double fuel)
        {
            FuelQuantity += (fuel * truckFuelDecrease);
        }

        public override string ToString()
        {
            return $"Truck: {this.FuelQuantity:f2}";
        }
    }
}
