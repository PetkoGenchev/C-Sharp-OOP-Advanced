using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }


        public string Start()
        {
            return $"{this.Color} Seat {this.Model}\r Engine start";

        }

        public string Stop()
        {
            return "Breaaak!";
        }
    }
}
