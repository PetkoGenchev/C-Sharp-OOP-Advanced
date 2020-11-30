using System;
using System.Collections.Generic;
using System.Linq;

namespace Encapsulation_Work_02.Core
{
    public class Engine
    {
        //Read data from the console
        //Process data
        //Print data to console

        private readonly ICollection<Person> people;
        private readonly ICollection<Product> products;


        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();

        }

        public void Run()
        {
            //Place business logic here

            try
            {
                this.PeopleInput();
                this.ProductsInput();


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

                    Person person = this.people.FirstOrDefault(p => p.Name == commandName);
                    Product product = this.products.FirstOrDefault(p => p.Name == commandProduct);

                    if (person != null && product != null)
                    {
                        string result = person.BuyProduct(product);
                        Console.WriteLine(result);
                    }
                }

                foreach (Person person in this.people)
                {
                    Console.WriteLine(person);
                }




            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }


        }

        private void PeopleInput()
        {
            string[] inputPeople = Console.ReadLine()
                        .Split(";", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();


            foreach (var itemPer in inputPeople)
            {
                var personDetails = itemPer.Split('=').ToArray();

                string personName = personDetails[0];
                int personMoney = int.Parse(personDetails[1]);

                Person person = new Person(personName, personMoney);

                this.people.Add(person);
            }
        }

        private void ProductsInput()
        {
            var inputProducts = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var itemProd in inputProducts)
            {
                var productDetails = itemProd.Split("=").ToArray();

                    Product product = new Product(productDetails[0], int.Parse(productDetails[1]));
                    products.Add(product);

            }
        }

    }
}