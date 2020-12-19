using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;
using Military.ENumerations;
using Military.Exceptions;

namespace Military
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {

        public SoldierCorpsEnumerator Corps { get; private set; }

        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = this.TryParseCorps(corps);
        }

        private SoldierCorpsEnumerator TryParseCorps(string corpsEntry)
        {
            SoldierCorpsEnumerator corps;

            bool parsed = Enum.TryParse<SoldierCorpsEnumerator>(corpsEntry, out corps);

            if (!parsed)
            {
                throw new InvalidCorpsException();
            }
            return corps;
        }
    }
}
