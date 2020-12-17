using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public class Repairs
    {
        public string Name { get; set; }
        public int Hours { get; set; }


        public Repairs(string name, int hours)
        {
            this.Name = name;
            this.Hours = hours;
        }
    }
}
