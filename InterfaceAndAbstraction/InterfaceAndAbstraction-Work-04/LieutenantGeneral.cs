using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;

namespace Military
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        List<Private> Privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, List<Private> privates) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }
    }
}
