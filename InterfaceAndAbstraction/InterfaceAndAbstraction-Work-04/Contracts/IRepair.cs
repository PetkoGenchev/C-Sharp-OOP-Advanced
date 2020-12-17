using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Contracts
{
    public interface IRepair
    {
        string Name { get; }
        int HoursWorked { get; }
    }
}
