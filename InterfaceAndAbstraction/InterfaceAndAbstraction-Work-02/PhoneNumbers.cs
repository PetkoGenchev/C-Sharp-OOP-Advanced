using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class PhoneNumbers
    {
        private string number;

        public PhoneNumbers(string phonenumber)
        {
            this.Number = phonenumber;
        }

        public string Number
        {
            get
            {
                return this.number;
            }
            private set
            {
                if (value.Length != 7 && value.Length != 10)
                {
                    throw new ArgumentException("Invalid number!");
                }
                this.number = value;
            }
        }
    }
}
