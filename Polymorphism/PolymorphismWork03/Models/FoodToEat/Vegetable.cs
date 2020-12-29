using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Abstract;

namespace WildFarm.Models
{
    public class Vegetable : Food
    {
        public Vegetable(int quantity) 
            : base(quantity)
        {
        }
    }
}
