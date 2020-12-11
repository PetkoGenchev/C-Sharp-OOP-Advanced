using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.GlobalMsg;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {

        public Smartphone()
        {

        }

        public string BrowseW(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new ArgumentException(InvalidMsg.InvalidUrlMsg);
            }
            return $"Browsing: {url}!";


        }

        public string CallOtherPhones(string phoneNumber)
        {
            if (!phoneNumber.All(x => char.IsDigit(x)))
            {
                throw new ArgumentException(InvalidMsg.InvalidNumberMsg);
            }
            return $"Calling... {phoneNumber}";
        }
    }
}
