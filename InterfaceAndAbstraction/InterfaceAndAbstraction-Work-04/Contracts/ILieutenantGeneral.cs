using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        ICollection<ISoldier> Privates { get; }

        void AddPrivate(ISoldier @private);
    }
}
