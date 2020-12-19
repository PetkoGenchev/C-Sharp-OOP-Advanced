using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Contracts
{
    public interface ICommando : ISpecialisedSoldier
    {
        ICollection<IMission> Missions { get; }

        void AddMission(IMission mission);
    }
}
