using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Encapsulation_Work_04.Common;
using Encapsulation_Work_04.Models;

namespace Encapsulation_Work_04
{
    public class Engine
    {
        private readonly ICollection<Team> teams;

        public Engine()
        {
            this.teams = new List<Team>();
        }

        public void Run()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(";").ToArray();

                if (input[0] == "END")
                {
                    break;
                }
                string actionOptions = input[0];
                string actionTeamName = input[1];

                try
                {
                    List<string> partialInput = input.Skip(1).ToList();



                    if (actionOptions == "Team")
                    {
                        if (string.IsNullOrWhiteSpace(actionTeamName))
                        {
                            throw new ArgumentException(GlobalConstants.EmptyNameMsg);
                        }
                        else
                        {
                            this.CreateNewTeam(partialInput);
                        }
                    }
                    else if (actionOptions == "Add")
                    {
                        this.AddPlayer(partialInput);
                    }
                    else if (actionOptions == "Remove")
                    {
                        this.RemovePlayer(partialInput);
                    }
                    else if (actionOptions == "Rating")
                    {
                        this.TeamRating(partialInput);
                    }

                }

                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }




            }

        }


        private void CreateNewTeam (IList<string> input)
        {
            string teamName = input[0];

            Team team = new Team(teamName);

            this.teams.Add(team);
        }

        private void AddPlayer(IList<string> input)
        {
            string teamName = input[0];
            string playerName = input[1];

            this.CheckIfTeamIsReal(teamName);

            Stats stats = this.StatsBuild(input.Skip(2).ToArray());

            Player player = new Player(playerName, stats);


            Team team = this.teams.First(t => t.Name == teamName);
            team.AddPlayer(player);

        }

        private void RemovePlayer(IList<string> input)
        {
            string teamName = input[0];
            string playerName = input[1];

            this.CheckIfTeamIsReal(teamName);

            Team team = this.teams.First(t => t.Name == teamName);
            team.RemovePlayer(playerName);
        }

        private void TeamRating(IList<string> input)
        {
            string teamName = input[0];

            this.CheckIfTeamIsReal(teamName);

            Team team = this.teams.First(t => t.Name == teamName);

            Console.WriteLine(team);
        }

        private Stats StatsBuild (string[] stat)
        {
            int endu = int.Parse(stat[0]);
            int spr = int.Parse(stat[1]);
            int drib = int.Parse(stat[2]);
            int pass = int.Parse(stat[3]);
            int shoot = int.Parse(stat[4]);

            Stats stats = new Stats(endu, spr, drib, pass, shoot);
            return stats;
        }

        private void CheckIfTeamIsReal(string teamName)
        {
            if (!this.teams.Any(t => t.Name == teamName))
            {
                throw new InvalidOperationException(String.Format(GlobalConstants.NonExistentTeam,teamName));
            }
        }




    }
}
