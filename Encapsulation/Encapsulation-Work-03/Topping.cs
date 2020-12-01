using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Work_03
{
    public class Topping
    {
        private const double meat = 1.2;
        private const double veggies = 0.8;
        private const double cheese = 1.1;
        private const double sauce = 0.9;
        private const double baseCallories = 2;

        private const string invalidToppingMsg = "Cannot place {0} on top of your pizza.";
        private const string invalidWeightMsg = "{0} weight should be in the range [1..50].";

        private string ToppingType { get;  set; }
        private double Weight { get;  set; }


        public Topping(string toppingType, double weight)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;
        }

        public double CalculateToppingCalories()
        {

            double toppingModifier = 0;

            if (this.ToppingType == "Meat")
            {
                toppingModifier = meat;
            }
            else if (this.ToppingType == "Veggies")
            {
                toppingModifier = veggies;
            }
            else if (this.ToppingType == "Cheese")
            {
                toppingModifier = cheese;
            }
            else if (this.ToppingType == "Sauce")
            {
                toppingModifier = sauce;
            }
            else
            {
                throw new ArgumentException(string.Format(invalidToppingMsg, this.ToppingType));
            }

            if (this.Weight < 1 || this.Weight > 50)
            {
                throw new ArgumentException(string.Format(invalidWeightMsg, this.ToppingType));
            }

            double calculation = this.Weight * toppingModifier * baseCallories;
            return calculation;
        }





    }
}
