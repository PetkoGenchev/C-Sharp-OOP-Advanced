using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Encapsulation_Work_04.Common;

namespace Encapsulation_Work_04
{
    public class Team
    {
        private string name;

        private readonly ICollection<Player> players;


        
        private Team()
        {
            this.players = new List<Player>();
        }

        public Team(string name)
            :this()
        {
            this.Name = name;
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

        public int Rating => this.players.Count > 0 ? (int)Math.Round(players.Average(p => p.SkillRating)) : 0;



        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }



        public void RemovePlayer(string playerName)
        {
            Player removePlayer = this.players.FirstOrDefault(p => p.Name == playerName);

            if (removePlayer == null)
            {
                throw new InvalidOperationException(string.Format(GlobalConstants.PlayerNotInTeamMsg, playerName, this.Name));
            }
            this.players.Remove(removePlayer);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
