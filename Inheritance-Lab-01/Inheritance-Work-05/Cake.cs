using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double DefaultGrams = 250;
        private const double DefaultCalories = 1000;
        private const decimal DefaultCakePrice = 5;


        public Cake(string name, decimal price, double grams, double calories) 
            : base(name, price, grams, calories)
        {

        }

        public override double Grams 
        {
            get => DefaultGrams;
        }

        public override double Calories 
        {
            get => DefaultCalories; 
        }

        public override decimal Price 
        {
            get => DefaultCakePrice;
        }
    }
}
