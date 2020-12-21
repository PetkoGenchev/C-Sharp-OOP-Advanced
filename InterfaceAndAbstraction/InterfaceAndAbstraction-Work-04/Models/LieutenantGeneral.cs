using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;

namespace Military
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private ICollection<ISoldier> privates;

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<ISoldier>();
        }


        public ICollection<ISoldier> Privates => this.privates;

        public void AddPrivate(ISoldier @private)
        {
            this.Privates.Add(@private);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine(base.ToString())
                .AppendLine("Privates: ");

            foreach (var soldier in this.privates)
            {
                sb.AppendLine($"  {soldier.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }


    }
}
