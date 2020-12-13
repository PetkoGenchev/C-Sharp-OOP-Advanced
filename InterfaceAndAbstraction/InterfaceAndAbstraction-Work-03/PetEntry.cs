using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control
{
    public class PetEntry : IEntry
    {
        public string Name { get; set; }
        public string Birthday { get; set; }
        public PetEntry(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
    }
}
