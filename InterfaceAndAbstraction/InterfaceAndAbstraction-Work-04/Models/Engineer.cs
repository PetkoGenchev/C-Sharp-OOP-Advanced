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


        public Engineer(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<IRepair>();
        }

        public void AddRepair(IRepair repair)
        {
            this.Repairs.Add(repair);
        }
    }
}
