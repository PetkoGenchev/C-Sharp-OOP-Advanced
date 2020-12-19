using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Military.Exceptions
{
    public class InvalidMissionException : Exception
    {
        private const string INV_MISSION_MSG = "Invalid mission";
        public InvalidMissionException()
            :base(INV_MISSION_MSG)
        {
        }

        public InvalidMissionException(string message) 
            : base(message)
        {
        }
    }
}
