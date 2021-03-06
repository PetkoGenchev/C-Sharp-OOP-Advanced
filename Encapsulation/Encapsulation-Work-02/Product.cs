﻿using System;

namespace Encapsulation_Work_02
{
    public class Product
    {
        private string name;
        private int cost;

        public Product(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.emptyNameException);
                }
                this.name = value;
            }
        }

        public int Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.emptyMoneyException);
                }
                this.cost = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
