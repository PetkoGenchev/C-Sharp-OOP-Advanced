using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;

namespace Military
{
    public class Spy : Soldier, ISpy
    {
        public int CodeNumber { get; set; }

        public Spy(string id, string firstName, string lastName, int codenumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codenumber;
        }
    }
}
