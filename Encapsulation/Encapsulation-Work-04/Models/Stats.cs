using System;
using System.Collections.Generic;
using System.Text;
using Encapsulation_Work_04.Common;

namespace Encapsulation_Work_04.Models
{
    public class Stats
    {

        private const int MinStats = 0;
        private const int MaxStats = 100;
        private const double countOfStats = 5;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;


        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance
        {
            get
            {
                return this.endurance;
            }
            private set
            {
                this.ValidatePlayerStats(nameof(this.Endurance), value);

                this.endurance = value;

            }
        }

        public int Sprint
        {
            get
            {
                return this.sprint;
            }
            private set
            {
                this.ValidatePlayerStats(nameof(this.Sprint), value);

                this.sprint = value;

            }
        }

        public int Dribble
        {
            get
            {
                return this.dribble;
            }
            private set
            {
                this.ValidatePlayerStats(nameof(this.Dribble), value);

                this.dribble = value;

            }
        }

        public int Passing
        {
            get
            {
                return this.passing;
            }
            private set
            {
                this.ValidatePlayerStats(nameof(this.Passing), value);

                this.passing = value;

            }
        }

        public int Shooting
        {
            get
            {
                return this.shooting;
            }
            private set
            {
                this.ValidatePlayerStats(nameof(this.Shooting), value);

                this.shooting = value;

            }
        }

        public double AvgRatingPerPlayer => (this.Endurance + this.Sprint +
            this.Dribble + this.Passing + this.Shooting) / countOfStats;

        private void ValidatePlayerStats(string name, int value)
        {
            if (value < MinStats || value > MaxStats)
            {
                throw new ArgumentException(string.Format(GlobalConstants.InvalidStatMsg,
                    name, MinStats, MaxStats));
            }
        }
    }
}
