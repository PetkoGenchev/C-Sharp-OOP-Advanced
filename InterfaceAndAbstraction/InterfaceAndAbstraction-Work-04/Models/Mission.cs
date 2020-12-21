using System;
using System.Collections.Generic;
using System.Text;
using Military.Contracts;
using Military.ENumerations;
using Military.Exceptions;

namespace Military
{
    public class Mission : IMission
    {
        public string CodeName { get; private set; }

        public MissionEnum MissionEnum { get; private set; }

        public Mission(string name, string state)
        {
            this.CodeName = name;
            this.MissionEnum = this.TryParseMission(state);
        }

        public void CompleteMission()
        {
            if (this.MissionEnum == MissionEnum.Finished)  // (int)this.MissionEnum == 2)
            {
                throw new InvalidCompletionException();
            }
            this.MissionEnum = MissionEnum.Finished;
        }

        private MissionEnum TryParseMission(string stateEntry)
        {
            MissionEnum mission;
            bool parsed = Enum.TryParse<MissionEnum>(stateEntry, out mission);

            if (!parsed)
            {
                throw new InvalidMissionException();
            }
            return mission;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.MissionEnum.ToString()}";
        }
    }
}
