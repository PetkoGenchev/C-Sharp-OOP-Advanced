using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class WebSite
    {

        private string site;

        public WebSite(string site)
        {
            this.Site = site;
        }

        public string Site
        {
            get
            {
                return this.site;
            }
            private set
            {
                if (value.Any(char.IsDigit))
                {
                    throw new ArgumentException("Invalid URL!");
                }
                this.site = value;
            }
        }
    }
}

