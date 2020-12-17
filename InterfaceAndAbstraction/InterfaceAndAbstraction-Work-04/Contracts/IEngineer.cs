﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Contracts
{
    public interface IEngineer
    {
        ICollection<IRepair> Repairs { get; }
    }
}
