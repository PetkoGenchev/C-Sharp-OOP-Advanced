using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Exceptions;
using WildFarm.Models.Abstract;

namespace WildFarm.Models
{
    public class Owl : Bird
    {
        private const double weightIncrease = 0.25;
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void EatFood(string name, int count)
        {
            if (name == "Meat")
            {
                this.FoodEaten += count;
                this.Weight += weightIncrease * count;
            }
            else
            {
                throw new ArgumentException(string.Format(WrongFoodTypeExc.wrong_Food_Exc_Msg, this.GetType().Name, name));
            }
        }

        public override string MakeSound()
        {
            return "Hoot Hoot";
        }


    }
}
