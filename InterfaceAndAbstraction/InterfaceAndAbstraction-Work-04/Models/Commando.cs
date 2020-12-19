using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;
using Military.ENumerations;

namespace Military
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public ICollection<IMission> Missions { get; }

        public Commando(int id, string firstName, string lastName, decimal salary, string corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public void AddMission(IMission mission)
        {
            this.Missions.Add(mission);
        }
    }
}
