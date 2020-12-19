using System;
using System.Linq;
using System.Collections.Generic;

using Military.Contracts;
using Military.IO.Contracts;
using Military.Core.Contracts;

namespace Military.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        private ICollection<ISoldier> soldiers;

        private Engine()
        {
            this.soldiers = new List<ISoldier>();
        }

        public Engine(IReader reader, IWriter writer)
            :this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string command;
            while ((command = this.reader.ReadLine()) != "End")
            {
                string[] commandSplit = command.Split().ToArray();

                string soldierType = commandSplit[0];
                int id = int.Parse(commandSplit[1]);
                string firstName = commandSplit[2];
                string lastName = commandSplit[3];

                ISoldier soldier;



                if (soldierType == "Private")
                {
                    decimal salary = decimal.Parse(commandSplit[4]);
                    soldier = AddPrivate(id, firstName, lastName, salary);
                }
                else if (soldierType == "LeutenantGeneral")
                {
                    decimal salary = decimal.Parse(commandSplit[4]);
                    soldier = new LieutenantGeneral(id, firstName, lastName, salary);

                    foreach (var privateId in commandSplit.Skip(5))
                    {
                        ISoldier privateToAdd = this.soldiers.First(s => s.Id == int.Parse(privateId));
                    }

                }
                else if (soldierType == "Engineer")
                {

                }
                else if (soldierType == "Commando")
                {

                }
                else if (soldierType == "Spy")
                {

                }
            }
        }

        private static ISoldier AddPrivate(int id, string firstName, string lastName, decimal salary)
        {
            return new Private(id, firstName, lastName, salary);
        }
    }
}
