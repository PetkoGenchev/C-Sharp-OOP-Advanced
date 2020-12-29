using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Abstract
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }
        public abstract void EatFood(string name, int count);

        public abstract string MakeSound();
        public abstract override string ToString();
    }
}
