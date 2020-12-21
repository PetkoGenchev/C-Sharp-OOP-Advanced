using System;
using System.Linq;
using System.Collections.Generic;

using Military.Contracts;
using Military.IO.Contracts;
using Military.Core.Contracts;
using Military.Exceptions;

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
            : this()
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

                ISoldier soldier = null;



                if (soldierType == "Private")
                {
                    decimal salary = decimal.Parse(commandSplit[4]);
                    soldier = AddPrivate(id, firstName, lastName, salary);
                }
                else if (soldierType == "LeutenantGeneral")
                {
                    soldier = AddGeneral(commandSplit, id, firstName, lastName);

                }
                else if (soldierType == "Engineer")
                {
                    decimal salary = decimal.Parse(commandSplit[4]);
                    string corps = commandSplit[5];

                    try
                    {
                        soldier = AddEngineer(commandSplit, id, firstName, lastName, salary, corps);

                    }
                    catch (InvalidCorpsException invCorpEx)
                    {

                        continue;
                    }

                }
                else if (soldierType == "Commando")
                {
                    decimal salary = decimal.Parse(commandSplit[4]);
                    string corps = commandSplit[5];

                    try
                    {
                        ICommando commando = GetCommmando(commandSplit, id, firstName, lastName, salary, corps);
                        soldier = commando;
                    }
                    catch (InvalidCorpsException invCorpEx)
                    {

                        continue;
                    }

                }
                else if (soldierType == "Spy")
                {
                    int codeNumber = int.Parse(commandSplit[4]);

                    soldier = new Spy(id, firstName, lastName, codeNumber);
                }

                if (soldier != null)
                {
                    this.soldiers.Add(soldier);
                }

            }

            foreach (var soldier in soldiers)
            {
                this.writer.WriteLine(soldier.ToString());
            }
        }


        private static ICommando GetCommmando(string[] commandSplit, int id, string firstName, string lastName, decimal salary, string corps)
        {
            ICommando commando = new Commando(id, firstName, lastName, salary, corps);

            string[] missionEntries = commandSplit.Skip(6).ToArray();


            for (int i = 0; i < missionEntries.Length; i += 2)
            {
                try
                {
                    string missionName = missionEntries[i];
                    string missionState = missionEntries[i + 1];

                    IMission mission = new Mission(missionName, missionState);
                    commando.AddMission(mission);

                }
                catch (InvalidMissionException invMissExc)
                {

                    continue;
                }

            }

            return commando;
        }

        private static ISoldier AddEngineer(string[] commandSplit, int id, string firstName, string lastName, decimal salary, string corps)
        {
            ISoldier soldier;
            Engineer engineer = new Engineer(id, firstName, lastName, salary, corps);

            string[] repairEntries = commandSplit.Skip(6).ToArray();

            for (int i = 0; i < repairEntries.Length; i += 2)
            {
                string partName = commandSplit[i];
                int hoursWorked = int.Parse(commandSplit[i + 1]);

                IRepair repair = new Repair(partName, hoursWorked);
                engineer.AddRepair(repair);
            }
            soldier = engineer;
            return soldier;
        }

        private ISoldier AddGeneral(string[] commandSplit, int id, string firstName, string lastName)
        {
            ISoldier soldier;
            decimal salary = decimal.Parse(commandSplit[4]);

            ILieutenantGeneral general = new
                LieutenantGeneral(id, firstName, lastName, salary);

            foreach (var privateId in commandSplit.Skip(5))
            {
                ISoldier privateToAdd = this.soldiers
                    .First(s => s.Id == int.Parse(privateId));

                general.AddPrivate(privateToAdd);
            }

            soldier = general;
            return soldier;
        }

        private static ISoldier AddPrivate(int id, string firstName, string lastName, decimal salary)
        {
            return new Private(id, firstName, lastName, salary);
        }
    }
}
