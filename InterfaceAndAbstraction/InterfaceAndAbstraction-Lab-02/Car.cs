using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public abstract class Car : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        protected Car(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public virtual string Start()
        {
            return $"{this.Color} Seat {this.Model} \nEngine Start";

        }

        public string Stop()
        {
            return "Breaaak!";
        }
    }
}
