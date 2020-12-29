using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Abstract
{
    public abstract class Food
    {
        public int Quantity { get; set; }

        public Food(int quantity)
        {
            this.Quantity = quantity;
        }
    }
}
