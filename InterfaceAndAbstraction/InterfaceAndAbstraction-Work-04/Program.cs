using System;
using System.Collections.Generic;
using Military.Contracts;

namespace Military
{
    public class Program
    {
        static void Main()
        {
            ICollection<ISoldier> soldiers = new List<ISoldier>();
            ISoldier soldier;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] commandSplit = command.Split();

                string soldierType = commandSplit[0];
                int iD = int.Parse(commandSplit[1]);
                string firstName = commandSplit[2];
                string lastName = commandSplit[3];
                decimal salary = decimal.Parse(commandSplit[4]);


                if (soldierType == typeof(Private).Name)
                {
                    soldier = new Private(iD, firstName, lastName, salary);
                }
                else if (soldierType == typeof(LieutenantGeneral).Name)
                {
                    ICollection<IPrivate> lieutenPrivates = new List<IPrivate>();
                }

                // enter logic


            }


            PrintResult(soldiers);
        }

        public static void PrintResult(ICollection<ISoldier> soldiers)
        {
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
