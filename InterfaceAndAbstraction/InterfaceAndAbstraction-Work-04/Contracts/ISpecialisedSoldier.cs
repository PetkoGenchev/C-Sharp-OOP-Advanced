using System;
using System.Collections.Generic;
using System.Text;
using Military.ENumerations;

namespace Military.Contracts
{
    public interface ISpecialisedSoldier : IPrivate
    {
        SoldierCorpsEnumerator Corps { get; }
    }
}
