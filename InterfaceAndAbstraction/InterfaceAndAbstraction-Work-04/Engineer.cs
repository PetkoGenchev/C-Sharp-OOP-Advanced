using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;

namespace Military
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {

        ICollection<Repairs> Repairs;


        public Engineer(string id, string firstName, string lastName, decimal salary, string corps, List<Repairs> repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = repairs;
        }

        ICollection<Repairs> IEngineer.Repairs => throw new NotImplementedException();
    }
}
