using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Contracts
{
    public interface ILieutenantGeneral
    {
        ICollection<IPrivate> Privates { get; }
    }
}
