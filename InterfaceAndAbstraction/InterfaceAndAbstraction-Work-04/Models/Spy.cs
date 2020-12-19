using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;

namespace Military
{
    public class Spy : Soldier, ISpy
    {
        public int CodeNumber { get; private set; }

        public Spy(int id, string firstName, string lastName, int codenumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codenumber;
        }


        public override string ToString()
        {
            return $"Name: {base.ToString()}" +
                Environment.NewLine +
                $"Code Number: {this.CodeNumber}";
        }
    }
}
