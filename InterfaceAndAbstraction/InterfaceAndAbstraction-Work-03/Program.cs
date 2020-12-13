using System;
using System.Collections.Generic;
using System.Linq;

namespace Border_Control
{
    public class Program
    {
        static void Main()
        {
            List<IEntry> entries = new List<IEntry>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                var inputArray = input.Split().ToList();

                string typeOfEntry = inputArray[0];

                if (typeOfEntry == "Citizen")
                {
                    PeopleEntry people = new PeopleEntry(inputArray[1], int.Parse(inputArray[2]),
                        inputArray[3], inputArray[4]);
                    entries.Add(people);
                }






            }

            string endDigits = Console.ReadLine();

            int counter = 0;
            
            foreach (IEntry item in entries)
            {


                if (item.EndsWithCheck(endDigits))
                {
                    counter++;
                    Console.WriteLine(item.Birthday);
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("< empty output >");
            }
        }
    }
}
