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

        public Commando(int id, string firstName, string lastName, decimal salary, SoldierCorpsEnumerator corps, ICollection<IMission> mission) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = mission;
        }
    }
}
