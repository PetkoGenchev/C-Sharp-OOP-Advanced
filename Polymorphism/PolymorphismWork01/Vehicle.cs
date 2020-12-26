using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get;  set; }
        public double FuelConsumption { get;  set; }
        public int TankCapacity { get; set; }

        public Vehicle(double fuelQuantity, double fuelConsumption, int tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public virtual string Drive(double distance)
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

        public virtual void Refuel(double fuel)
        {
            this.FuelQuantity += fuel;
        }


        public abstract override string ToString();
    }
}
