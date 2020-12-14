using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;

namespace Military
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public string corps;

        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get
            {
                return this.corps;
            }
            private set
            {
                if (value == "Airforces" || value == "Marines")
                {
                    throw new ArgumentException();
                }
                this.corps = value;
            }
        }
    }
}
