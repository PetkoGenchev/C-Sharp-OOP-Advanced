using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;

namespace Military
{
    public abstract class Soldier : ISoldier
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Soldier(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }


    }
}
