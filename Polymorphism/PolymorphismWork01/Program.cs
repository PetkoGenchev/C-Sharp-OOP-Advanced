using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicles
{
    public class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string[] carInfo = Console.ReadLine().Split().ToArray();

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), int.Parse(carInfo[3]));
            vehicles.Add(car);

            string[] truckInfo = Console.ReadLine().Split().ToArray();

            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), int.Parse(truckInfo[3]));
            vehicles.Add(truck);

            int commandCount = int.Parse(Console.ReadLine());


            for (int i = 0; i < commandCount; i++)
            {
                string command = Console.ReadLine();

                string[] commandSplit = command.Split().ToArray();

                string actionType = commandSplit[0];
                string vehicleType = commandSplit[1];
                double amount = double.Parse(commandSplit[2]);


                if (actionType == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        Console.WriteLine(car.Drive(amount));
                    }
                    else
                    {
                        Console.WriteLine(truck.Drive(amount));
                    }
                }
                else
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(amount);
                    }
                    else
                    {
                        truck.Refuel(amount);
                    }
                }
            }

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }

        
        
        
        }
    }
}
