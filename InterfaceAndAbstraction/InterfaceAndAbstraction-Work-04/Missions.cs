using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public class Missions
    {
        public string Name { get; set; }
        public string State { get; set; }

        public Missions(string name, string state)
        {
            this.Name = name;
            this.State = state;
        }
    }
}
