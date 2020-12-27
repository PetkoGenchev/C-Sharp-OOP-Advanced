using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Contracts;
using Vehicles.Exceptions;

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
            if (fuel <= 0)
            {
                throw new ArgumentException(NegativeFuelExc.Negative_Fuel_MSG);
            }

            if (this.FuelQuantity + fuel > this.TankCapacity)
            {
                throw new ArgumentException(string.Format(InvalidFuelAmountExc.Invalid_Fuel_Amount_MSG, fuel));
            }

            this.FuelQuantity += (fuel * truckFuelDecrease);
        }

        public override string ToString()
        {
            return $"Truck: {this.FuelQuantity:f2}";
        }
    }
}
