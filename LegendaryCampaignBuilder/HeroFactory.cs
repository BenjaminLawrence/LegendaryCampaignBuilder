using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryCampaignBuilder
{
    internal class HeroFactory
    {
        // Covert = 1, Instinct = 2, Ranged = 4, Strength = 8, Tech = 16
        public List<Hero> GetCoreGameHeroes()
        {
            List<Hero> heroes = new List<Hero>();
            heroes.Add(new Hero("Black Widow", 2, HeroTeam.Avengers, (HeroClass)17));
            heroes.Add(new Hero("Captain America", 2, HeroTeam.Avengers, (HeroClass) 27));
            heroes.Add(new Hero("Cyclops", 1, HeroTeam.XMen, (HeroClass) 12));
            heroes.Add(new Hero("Deadpool", 1, HeroTeam.None, (HeroClass) 19));
            heroes.Add(new Hero("Emma Frost", 1, HeroTeam.XMen, (HeroClass) 15));
            heroes.Add(new Hero("Gambit", 1, HeroTeam.XMen, (HeroClass) 7));
            heroes.Add(new Hero("Hawkeye", 1, HeroTeam.Avengers, (HeroClass) 18));
            heroes.Add(new Hero("Hulk", 1, HeroTeam.Avengers, (HeroClass) 10));
            heroes.Add(new Hero("Iron Man", 1, HeroTeam.Avengers, (HeroClass) 20));
            heroes.Add(new Hero("Nick Fury", 1, HeroTeam.Shield, (HeroClass) 25));
            heroes.Add(new Hero("Rogue", 1, HeroTeam.XMen, (HeroClass) 9));
            heroes.Add(new Hero("Spider-Man", 1, HeroTeam.SpiderFriends, (HeroClass) 27));
            heroes.Add(new Hero("Storm", 1, HeroTeam.XMen, (HeroClass) 6));
            heroes.Add(new Hero("Thor", 1, HeroTeam.Avengers, (HeroClass) 12));
            heroes.Add(new Hero("Wolverine", 1, HeroTeam.XMen, (HeroClass) 2));
            return heroes;
        }
    }
}
