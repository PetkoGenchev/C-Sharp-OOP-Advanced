﻿using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;

namespace Military
{
    public class Repair : IRepair
    {
        public string Name { get; private set; }
        public int HoursWorked { get; private set; }

        public Repair(string name, int hours)
        {
            this.Name = name;
            this.HoursWorked = hours;
        }

        public override string ToString()
        {
            return $"Part Name: {this.Name} Hours Worked: {this.HoursWorked}";
        }
    }
}
