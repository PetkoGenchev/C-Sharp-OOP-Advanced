using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control
{
    public class PeopleEntry : IEntry
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthday { get; set; }

        public PeopleEntry(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
        }

    }
}
