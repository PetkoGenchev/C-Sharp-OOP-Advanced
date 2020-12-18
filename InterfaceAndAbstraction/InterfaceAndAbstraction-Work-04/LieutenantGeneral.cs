using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;

namespace Military
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public ICollection<IPrivate> Privates { get; }

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, ICollection<IPrivate> privates) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var @private in Privates)
            {

            }

            return $"{base.ToString()}";
        }
    }
}
