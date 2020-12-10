using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PhoneNumbers> phonenumbers = new List<PhoneNumbers>();
            List<WebSite> websites = new List<WebSite>();

            string[] phoneInput = Console.ReadLine().Split().ToArray();
            string[] webInput = Console.ReadLine().Split().ToArray();

            foreach (string item in phoneInput)
            {
                var num = new PhoneNumbers(item);
                phonenumbers.Add(num);
            }

            foreach (var item in webInput)
            {
                var web = new WebSite(item);
                websites.Add(web);
            }


        }
    }
}
