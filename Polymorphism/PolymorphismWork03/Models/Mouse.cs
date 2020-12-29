using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Exceptions;
using WildFarm.Models.Abstract;

namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        private const double weightIncrease = 0.10;
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void EatFood(string name, int count)
        {
            if (name == "Vegetable" || name == "Fruit")
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
            return "Squeak";
        }

    }
}
