using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Contracts;

namespace Vehicles
{
    public class Car : Vehicle, ICar
    {

        private const double carFuelConsumptionIncrease = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, int tankCapacity) 
            : base(fuelQuantity, fuelConsumption+carFuelConsumptionIncrease,tankCapacity)
        {

        }

        public override string ToString()
        {
            return $"Car: {this.FuelQuantity:f2}";
        }
    }
}
