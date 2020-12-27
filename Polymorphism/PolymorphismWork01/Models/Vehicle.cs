using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Contracts;
using Vehicles.Exceptions;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity { get;  set; }
        public double FuelConsumption { get;  set; }
        public int TankCapacity { get; set; }

        public Vehicle(double fuelQuantity, double fuelConsumption, int tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;

        }


        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }


            }
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
            if (fuel <= 0)
            {
                throw new ArgumentException(NegativeFuelExc.Negative_Fuel_MSG);
            }

            if (this.fuelQuantity + fuel > this.TankCapacity)
            {
                throw new ArgumentException(string.Format(InvalidFuelAmountExc.Invalid_Fuel_Amount_MSG,fuel));
            }

            this.FuelQuantity += fuel;
        }


        public abstract override string ToString();


    }
}
