using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Abstract;

namespace WildFarm.Models
{
    public class Hen : Bird
    {
        private const double weightIncrease = 0.35;

        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void EatFood(string name, int count)
        {
                this.FoodEaten += count;
                this.Weight += weightIncrease * count;
        }

        public override string MakeSound()
        {
            return "Cluck";
        }
    }
}
