﻿using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;

namespace Military
{
    public class Private : Soldier, IPrivate
    {
        public decimal Salary { get; private set; }

        public Private(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }


        public override string ToString()
        {
            return $"Name: {base.ToString()} Salary: {this.Salary:f2}";
        }
    }
}
