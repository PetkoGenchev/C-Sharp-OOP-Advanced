using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;

namespace Military
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        ICollection<ILieutenantGeneral> Privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, List<Private> privates) 
            : base(id, firstName, lastName, salary)
        {
            //this.Privates = privates;
        }

        public ICollection<IPrivate> Privates => throw new NotImplementedException();
    }
}
