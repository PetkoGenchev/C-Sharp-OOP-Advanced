using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private double coffeeMilliliters;
        private decimal coffeePrice;
        public double Caffeine { get; set; }

        public double CoffeeMilliliters
        {
            get
            {
                return 50;
            }
            set
            {
                this.coffeeMilliliters = value;
            }
        }

        public decimal CoffeePrice
        {
            get
            {
                return 3.50m;
            }
            set
            {
                this.coffeePrice = value;
            }
        }

        public Coffee(string name, decimal price, double milliliters) 
            : base(name, price, milliliters)
        {
        }
    }
}
