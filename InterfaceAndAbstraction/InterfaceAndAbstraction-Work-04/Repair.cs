using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;

namespace Military
{
    public class Repair : IRepair
    {
        public string Name { get; }
        public int HoursWorked { get; }

        public Repair(string name, int hours)
        {
            this.Name = name;
            this.HoursWorked = hours;
        }
    }
}
