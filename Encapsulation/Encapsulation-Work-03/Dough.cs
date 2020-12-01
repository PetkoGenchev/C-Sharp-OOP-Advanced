using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Work_03
{
    public class Dough
    {
        private const double flourWhite = 1.5;
        private const double flourWholegrain = 1.0;
        private const double bakeCrispy = 0.9;
        private const double bakeChewy = 1.1;
        private const double bakeHomemade = 1.0;
        private const double calloriesPerGram = 2.0;


        private string flourType;
        private string bakingTechnique;
        private double grams;

        public Dough(string flourType, string bakingTechnique, double grams)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Grams = grams;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if (value != "White" && value != "Wholegrain" )
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (value != "Crispy" && value != "Chewy" && value != "Homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        public double Grams
        {
            get
            {
                return this.grams;
            }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.grams = value;
            }
        }


        public double CalculateDoughCallories()
        {
            double flour = 0;
            double type = 0;


            if (this.FlourType == "White")
            {
                flour = flourWhite;
            }
            else
            {
                flour = flourWholegrain;
            }

            if (this.BakingTechnique == "Crispy")
            {
                type = bakeCrispy;
            }
            else if (this.BakingTechnique == "Chewy")
            {
                type = bakeChewy;
            }
            else
            {
                type = bakeHomemade;
            }

            double calculation = calloriesPerGram * this.Grams * flour * type;
            return calculation;
        }



    }
}
