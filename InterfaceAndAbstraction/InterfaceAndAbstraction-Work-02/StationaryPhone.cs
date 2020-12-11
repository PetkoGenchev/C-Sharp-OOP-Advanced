using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.GlobalMsg;

namespace Telephony
{
    public class StationaryPhone : ICall
    {
        public string CallOtherPhones(string phoneNumber)
        {
            if (!phoneNumber.All(x => char.IsDigit(x)))
            {
                throw new ArgumentException(InvalidMsg.InvalidNumberMsg);
            }

            return $"Dialing... {phoneNumber}";



        }
    }
}
