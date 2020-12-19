using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Exceptions
{
    public class InvalidCorpsException : Exception
    {
        private const string EXC_MSG = "Invalid corps!";

        public InvalidCorpsException()
            :base(EXC_MSG)
        {

        }

        public InvalidCorpsException(string message) 
            : base(message)
        {

        }
    }
}
