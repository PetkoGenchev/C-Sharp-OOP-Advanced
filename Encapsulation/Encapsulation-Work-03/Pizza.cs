using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Encapsulation_Work_03
{
    public class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        private List<Topping> toppings { get; set; }

        private int numberOfToppings;
        private double totalCalories;

        private const string pizzaNameMsg = "Pizza name should be between 1 and 15 symbols.";
        private const string pizzaToppingsMsg = "Number of toppings should be in range [0..10].";



        public Pizza()
        {
            this.toppings = new List<Topping>();
        }


        public void Run()
        {
            string[] nameEntry = Console.ReadLine().Split(" ").ToArray();
            string pizzaName = nameEntry[1];

            if (string.IsNullOrEmpty(pizzaName) || pizzaName.Length > 15)
            {
                throw new ArgumentException(pizzaNameMsg);
            }


            string[] doughEntry = Console.ReadLine()
                .Split(" ")
                .ToArray();
            string entryDoughFlour = char.ToUpper(doughEntry[1].First()) + doughEntry[1].Substring(1).ToLower();
            string entryDoughBake = char.ToUpper(doughEntry[2].First()) + doughEntry[2].Substring(1).ToLower();
            double entryDoughGrams = double.Parse(doughEntry[3]);

            Dough dough = new Dough(entryDoughFlour, entryDoughBake, entryDoughGrams);
            totalCalories += dough.CalculateDoughCallories();

            while (true)
            {
                string topInput = Console.ReadLine();
                numberOfToppings++;

                if (numberOfToppings > 10)
                {
                    throw new ArgumentException(pizzaToppingsMsg);
                }

                if (topInput == "END")
                {
                    break;
                }

                string[] toppingEntry = topInput.Split(" ").ToArray();
                string entryToppingName = char.ToUpper(toppingEntry[1].First()) + toppingEntry[1].Substring(1).ToLower();
                double entryToppingWeight = double.Parse(toppingEntry[2]);


                Topping topping = new Topping(entryToppingName, entryToppingWeight);
                totalCalories += topping.CalculateToppingCalories();

            }

        }

        public override string ToString()
        {
            return $"{this.Name} - {this.totalCalories:f2} Calories.";
        }



    }
}
