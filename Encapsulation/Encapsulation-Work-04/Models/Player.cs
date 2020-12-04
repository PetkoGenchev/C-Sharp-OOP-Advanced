using System;
using System.Collections.Generic;
using System.Text;
using Encapsulation_Work_04.Common;
using Encapsulation_Work_04.Models;

namespace Encapsulation_Work_04
{
    public class Player
    {
        private string name;

        public Stats Stats { get; set; }

        public double SkillRating => this.Stats.AvgRatingPerPlayer;

        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }


        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.EmptyNameMsg);
                }
                this.name = value;
            }
        }






    }
}
