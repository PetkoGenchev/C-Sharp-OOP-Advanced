﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Contracts
{
    public interface ICommando 
    {
        ICollection<IMission> Missions { get; }
    }
}