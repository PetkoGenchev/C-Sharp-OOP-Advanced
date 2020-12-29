using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Abstract;

namespace WildFarm.Models
{
    public class Seeds : Food
    {
        public Seeds(int quantity) 
            : base(quantity)
        {
        }
    }
}
