using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Contracts;

namespace Vehicles
{
    public class Bus : Vehicle, IBus
    {
        private const double Air_Conditionining_Consumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, int tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }


        public override string Drive(double distance)
        {
            double fuelNeeded = distance * (this.FuelConsumption + Air_Conditionining_Consumption);

            if (this.FuelQuantity >= fuelNeeded)
            {
                this.FuelQuantity -= fuelNeeded;
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }



        public string DriveEmpty(double distance)
        {
            double fuelNeeded = distance * (this.FuelConsumption);

            if (this.FuelQuantity >= fuelNeeded)
            {
                this.FuelQuantity -= fuelNeeded;
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }
        public override string ToString()
        {
            return $"Bus: {this.FuelQuantity:f2}";
        }
    }
}
