using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;

namespace Military
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        List<Missions> Mission;

        public Commando(string id, string firstName, string lastName, decimal salary, string corps, List<Missions> mission) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Mission = mission;
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("Name: ", this.FirstName, " ", this.LastName, " ", "Id: ", this.Id, " ", "Salary: ", this.Salary);
        //    sb.AppendLine("Corps: ", this.Corps);
        //    sb.AppendLine("Missions:");

        //    return sb.ToString();
        //}
    }
}
