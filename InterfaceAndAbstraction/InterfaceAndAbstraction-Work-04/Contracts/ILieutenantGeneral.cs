using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        ICollection<IPrivate> Privates { get; }

        void AddPrivate(IPrivate @private);
    }
}
