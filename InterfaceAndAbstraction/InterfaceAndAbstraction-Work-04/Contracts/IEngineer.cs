using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Contracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        ICollection<IRepair> Repairs { get; }

        void AddRepair(IRepair repair);
    }
}
