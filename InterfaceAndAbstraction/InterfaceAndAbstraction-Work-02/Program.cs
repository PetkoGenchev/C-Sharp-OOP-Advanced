using System;
using System.Collections.Generic;
using System.Linq;
using Telephony.GlobalMsg;

namespace Telephony
{
    public class Program
    {
        public static void Main()
        {
            string[] phoneInput = Console.ReadLine().Split().ToArray();
            string[] siteInput = Console.ReadLine().Split().ToArray();

            var stationary = new StationaryPhone();
            var smart = new Smartphone();


            for (int i = 0; i < phoneInput.Length; i++)
            {
                try
                {

                    if (phoneInput[i].Length == 7)
                    {
                        Console.WriteLine(stationary.CallOtherPhones(phoneInput[i]));
                    }
                    else if (phoneInput[i].Length == 10)
                    {
                        Console.WriteLine(smart.CallOtherPhones(phoneInput[i]));
                    }
                    else
                    {
                        throw new ArgumentException(InvalidMsg.InvalidNumberMsg);
                    }



                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            foreach (var url in siteInput)
            {
                try
                {
                    Console.WriteLine(smart.BrowseW(url));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

            }
        }
    }
}
