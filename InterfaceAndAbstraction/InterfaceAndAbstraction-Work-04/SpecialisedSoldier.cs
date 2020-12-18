using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;
using Military.ENumerations;

namespace Military
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {

        public SoldierCorpsEnumerator Corps { get; }

        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, SoldierCorpsEnumerator corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }
    }
}
