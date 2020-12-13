using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control
{
    public class RobotEntry
    {
        public string Model { get; set; }
        public string Id { get; set; }
        public RobotEntry(string name, string id)
        {
            this.Model = name;
            this.Id = id;
        }
    }
}
