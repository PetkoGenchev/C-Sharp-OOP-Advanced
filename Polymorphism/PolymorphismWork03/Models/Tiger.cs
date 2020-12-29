using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Exceptions;
using WildFarm.Models.Abstract;

namespace WildFarm.Models
{
    public class Tiger : Feline
    {
        private const double weightIncrease = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
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
            return "ROAR!!!";
        }
    }
}
