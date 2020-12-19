using System;
using System.Collections.Generic;
using System.Text;

namespace Military.Exceptions
{
    public class InvalidCompletionException : Exception
    {
        private const string Mission_Complete_MSG = "Mission already completed";
        public InvalidCompletionException()
            :base(Mission_Complete_MSG)
        {
        }

        public InvalidCompletionException(string message) : base(message)
        {

        }
    }
}
