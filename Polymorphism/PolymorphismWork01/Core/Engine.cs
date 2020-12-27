using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vehicles.Contracts;
using Vehicles.Core.Contracts;
using Vehicles.IO.Contracts;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        private ICollection<IVehicle> vehicles;

        private Engine()
        {
            this.vehicles = new List<IVehicle>();
        }

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }


        public void Run()
        {
            

            string[] carInfo = this.reader.ReadLine().Split().ToArray();
            ICar car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), int.Parse(carInfo[3]));
            vehicles.Add(car);


            string[] truckInfo = this.reader.ReadLine().Split().ToArray();
            ITruck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), int.Parse(truckInfo[3]));
            vehicles.Add(truck);


            string[] busInfo = this.reader.ReadLine().Split().ToArray();
            IBus bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), int.Parse(busInfo[3]));
            vehicles.Add(bus);


            int commandCount = int.Parse(this.reader.ReadLine());



            for (int i = 0; i < commandCount; i++)
            {
                string command = this.reader.ReadLine();

                string[] commandSplit = command.Split().ToArray();

                string actionType = commandSplit[0];
                string vehicleType = commandSplit[1];
                double amount = double.Parse(commandSplit[2]);

                if (actionType == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        this.writer.WriteLine(car.Drive(amount));
                    }
                    else if (vehicleType == "Truck")
                    {
                        this.writer.WriteLine(truck.Drive(amount));
                    }
                    else
                    {
                        this.writer.WriteLine(bus.Drive(amount));
                    }
                }
                else if (actionType == "Refuel")
                {


                    try
                    {
                        if (vehicleType == "Car")
                        {
                            car.Refuel(amount);
                        }
                        else if (vehicleType == "Truck")
                        {
                            truck.Refuel(amount);
                        }
                        else
                        {
                            bus.Refuel(amount);
                        }

                    }
                    catch (ArgumentException ae)
                    {

                        this.writer.WriteLine(ae.Message);
                    }

                }
                else
                {
                    bus.DriveFull(amount);
                }
            }


            foreach (IVehicle vehicle in vehicles)
            {
                this.writer.WriteLine(vehicle.ToString());
            }




        }
    }
}
