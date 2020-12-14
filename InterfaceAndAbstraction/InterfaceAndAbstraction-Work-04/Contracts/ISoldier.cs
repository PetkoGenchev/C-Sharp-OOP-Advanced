using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Contracts
{
    public interface ISoldier
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
