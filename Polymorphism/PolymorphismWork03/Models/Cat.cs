using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Abstract;
using WildFarm.Exceptions;

namespace WildFarm.Models
{
    public class Cat : Feline
    {
        private const double weightIncrease = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {

        }

        public override void EatFood(string name, int count)
        {
            if (name == "Vegetable" || name == "Meat")
            {
                this.FoodEaten += count;
                this.Weight += weightIncrease * count;
            }
            else
            {
                throw new ArgumentException(string.Format(WrongFoodTypeExc.wrong_Food_Exc_Msg,this.GetType().Name,name));
            }
        }

        public override string MakeSound()
        {
            return "Meow";
        }

    }
}
