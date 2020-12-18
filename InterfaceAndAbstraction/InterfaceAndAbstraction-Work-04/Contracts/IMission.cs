using System;
using System.Collections.Generic;
using System.Text;
using Military.ENumerations;

namespace Military.Contracts
{
    public interface IMission
    {
        string CodeName { get; }

        MissionEnum MissionEnum { get; }

        void CompleteMission(string name);
    }
}
