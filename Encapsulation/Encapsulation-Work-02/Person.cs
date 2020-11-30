using System;
using System.Collections.Generic;

namespace Encapsulation_Work_02
{
    public class Person
    {
        private string name;

        private int money;

        private List<Product> products;

        private const string notEnoughtMoneyMsg = "{0} can't afford {1}";
        private const string purchasedProductMsg = "{0} bought {1}";

        private Person()
        {
            this.Products = new List<Product>();
        }


        public Person(string name, int money)
            :this()
        {
            this.Name = name;
            this.Money = money;
        }


        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(GlobalConstants.emptyNameException);
                }
                this.name = value;
            }
        }

        public int Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.emptyMoneyException);
                }
                this.money = value;
            }
        }

        public List<Product> Products
        {
            get
            {
                return this.products;
            }
            private set
            {
                this.products = value;
            }
        }


        public string BuyProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                return string.Format(notEnoughtMoneyMsg, this.Name, product.Name);
            }

            this.Money -= product.Cost;
            this.Products.Add(product);
            return string.Format(purchasedProductMsg, this.Name, product.Name);
        }



        public override string ToString()
        {
            string productOutput = this.Products.Count > 0 ? string.Join(", ", this.Products) : "Nothing bought";

            return $"{this.Name} - {productOutput}";
        }




    }
}
