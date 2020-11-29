using System;
using System.Linq;
using System.Collections.Generic;

namespace Encapsulation_Work_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfPeople = new List<Person>();
            var listOfProducts = new List<Product>();

            var inputPeople = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var itemPer in inputPeople)
            {
                var personDetails = itemPer.Split("=").ToArray();

                try
                {
                     Person person = new Person(personDetails[0], int.Parse(personDetails[1]));
                    listOfPeople.Add(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
            }



            var inputProducts = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var itemProd in inputProducts)
            {
                var productDetails = itemProd.Split("=").ToArray();

                try
                {
                    Product product = new Product(productDetails[0], int.Parse(productDetails[1]));
                    listOfProducts.Add(product);
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                    return;
                }

            }


            while (true)
            {
                var commands = Console.ReadLine();

                if (commands == "END")
                {
                    break;
                }

                var commandsArray = commands.Split().ToArray();
                string commandName = commandsArray[0];
                string commandProduct = commandsArray[1];



            }
        }
    }
}
