using System;
using System.Collections.Generic;

namespace Raiding
{
    class Program
    {
        static void Main()
        {
            int amountOfHeroes = int.Parse(Console.ReadLine());

            List<BaseHero> baseHeroes = new List<BaseHero>();
            int totalPower = 0;

            for (int i = 0; i < amountOfHeroes; i++)
            {
                string name = Console.ReadLine();
                string heroType = Console.ReadLine();

                BaseHero hero = null;


                if (heroType == "Druid")
                {
                     hero = new Druid(name);
                }
                else if (heroType == "Paladin")
                {
                     hero = new Paladin(name);
                }
                else if (heroType == "Rogue")
                {
                     hero = new Rogue(name);
                }
                else if (heroType == "Warrior")
                {
                     hero = new Warrior(name);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }

                if (hero != null)
                {
                    baseHeroes.Add(hero);
                    totalPower += hero.Power;
                }
                else
                {
                    i--;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            if (baseHeroes.Count == 0)
            {
                Console.WriteLine("Defeat...");
                return;
            }


            foreach (BaseHero hero in baseHeroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            if (bossPower <= totalPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
