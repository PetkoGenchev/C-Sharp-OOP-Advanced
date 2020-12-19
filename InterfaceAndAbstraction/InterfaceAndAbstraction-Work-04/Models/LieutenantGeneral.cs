using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;

namespace Military
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private ICollection<IPrivate> privates;

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<IPrivate>();
        }


        public ICollection<IPrivate> Privates => this.privates;

        public void AddPrivate(IPrivate @private)
        {
            this.Privates.Add(@private);
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
