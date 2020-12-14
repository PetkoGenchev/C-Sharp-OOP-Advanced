using System;
using System.Collections.Generic;
using System.Linq;

namespace Border_Control
{
    public class Program
    {
        static void Main()
        {
            List<IBuyer> buyers = new List<IBuyer>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                var entry = Console.ReadLine().Split().ToList();

                if (entry.Count == 4)
                {
                    Citizen citizen = new Citizen(entry[0], int.Parse(entry[1]), entry[2], entry[3]);
                    buyers.Add(citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(entry[0], int.Parse(entry[1]), entry[2]);
                    buyers.Add(rebel);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }
                else if (buyers.Any(x => x.Name == command))
                {
                    IBuyer buyer = buyers.FirstOrDefault(x => x.Name == command);

                    buyer.BuyFood();
                }
            }

            int totalFood = 0;

            foreach (IBuyer buyer in buyers)
            {
                totalFood += buyer.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
}
