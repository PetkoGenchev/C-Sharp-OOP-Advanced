using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;
using Military.ENumerations;

namespace Military
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {

        public ICollection<IRepair> Repairs { get; }


        public Engineer(int id, string firstName, string lastName, decimal salary, SoldierCorpsEnumerator corps, ICollection<IRepair> repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = repairs;
        }

    }
}
