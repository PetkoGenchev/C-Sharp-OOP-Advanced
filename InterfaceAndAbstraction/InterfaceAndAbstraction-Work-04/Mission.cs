using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;
using Military.ENumerations;

namespace Military
{
    public class Mission : IMission
    {
        public string CodeName { get; }

        public MissionEnum MissionEnum { get; }

        public Mission(string name, MissionEnum state)
        {
            this.CodeName = name;
            this.MissionEnum = state;
        }

        public void CompleteMission(string name)
        {

        }
    }
}
