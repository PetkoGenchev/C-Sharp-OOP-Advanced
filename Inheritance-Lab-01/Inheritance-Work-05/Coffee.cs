using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public double coffeeMilliliters = 50;
        public decimal coffeePrice = 3.50M;
        public double Caffeine { get; set; }


        public Coffee(string name, decimal price, double milliliters, double caffeine) 
            : base(name, price, milliliters)
        {
            this.Caffeine = caffeine;
        }
    }
}
