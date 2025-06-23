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
        public List<Hero> GetCoreHeroes()
        {
            List<Hero> heroes = new List<Hero>();
            heroes.Add(new Hero("Black Widow", 2, HeroTeam.Avengers, (HeroClass)17));
            heroes.Add(new Hero("Captain America", 2, HeroTeam.Avengers, (HeroClass)27));
            heroes.Add(new Hero("Cyclops", 1, HeroTeam.XMen, (HeroClass)12));
            heroes.Add(new Hero("Deadpool", 1, HeroTeam.None, (HeroClass)19));
            heroes.Add(new Hero("Emma Frost", 1, HeroTeam.XMen, (HeroClass)15));
            heroes.Add(new Hero("Gambit", 1, HeroTeam.XMen, (HeroClass)7));
            heroes.Add(new Hero("Hawkeye", 1, HeroTeam.Avengers, (HeroClass)18));
            heroes.Add(new Hero("Hulk", 1, HeroTeam.Avengers, (HeroClass)10));
            heroes.Add(new Hero("Iron Man", 1, HeroTeam.Avengers, (HeroClass)20));
            heroes.Add(new Hero("Nick Fury", 1, HeroTeam.Shield, (HeroClass)25));
            heroes.Add(new Hero("Rogue", 1, HeroTeam.XMen, (HeroClass)9));
            heroes.Add(new Hero("Spider-Man", 1, HeroTeam.SpiderFriends, (HeroClass)27));
            heroes.Add(new Hero("Storm", 1, HeroTeam.XMen, (HeroClass)6));
            heroes.Add(new Hero("Thor", 1, HeroTeam.Avengers, (HeroClass)12));
            heroes.Add(new Hero("Wolverine", 1, HeroTeam.XMen, (HeroClass)2));
            return heroes;
        }

        public List<Hero> GetDarkCityHeroes()
        {
            List<Hero> heroes = new List<Hero>();
            heroes.Add(new Hero("Angel", 1, HeroTeam.XMen, (HeroClass)11));
            heroes.Add(new Hero("Bishop", 1, HeroTeam.XMen, (HeroClass)21));
            heroes.Add(new Hero("Blade", 1, HeroTeam.MarvelKnights, (HeroClass)27));
            heroes.Add(new Hero("Cable", 1, HeroTeam.XForce, (HeroClass)21));
            heroes.Add(new Hero("Colossus", 1, HeroTeam.XForce, (HeroClass)9));
            heroes.Add(new Hero("Daredevil", 1, HeroTeam.MarvelKnights, (HeroClass)11));
            heroes.Add(new Hero("Domino", 2, HeroTeam.XForce));
            heroes.Add(new Hero("Elektra", 1, HeroTeam.MarvelKnights));
            heroes.Add(new Hero("Forge", 1, HeroTeam.XForce));
            heroes.Add(new Hero("Ghost Rider", 1, HeroTeam.MarvelKnights));
            heroes.Add(new Hero("Iceman", 2, HeroTeam.XMen));
            heroes.Add(new Hero("Iron Fist", 1, HeroTeam.MarvelKnights));
            heroes.Add(new Hero("Jean Grey", 1, HeroTeam.XMen));
            heroes.Add(new Hero("Nightcrawler", 1, HeroTeam.XMen));
            heroes.Add(new Hero("Professor X", 1, HeroTeam.XMen));
            heroes.Add(new Hero("Punisher", 1, HeroTeam.MarvelKnights));
            heroes.Add(new Hero("Wolverine (X-Force)", 1, HeroTeam.XForce));
            return heroes;
        }

        public List<Hero> GetVillainsHeroes()
        {
            List<Hero> heroes = new List<Hero>();
            heroes.Add(new Hero("Bullseye"));
            heroes.Add(new Hero("Dr. Octopus"));
            heroes.Add(new Hero("Electro"));
            heroes.Add(new Hero("Enchantress"));
            heroes.Add(new Hero("Green Goblin"));
            heroes.Add(new Hero("Juggernaut"));
            heroes.Add(new Hero("Kingpin"));
            heroes.Add(new Hero("Kraven"));
            heroes.Add(new Hero("Loki"));
            heroes.Add(new Hero("Magneto"));
            heroes.Add(new Hero("Mysterio"));
            heroes.Add(new Hero("Mystique"));
            heroes.Add(new Hero("Sabretooth"));
            heroes.Add(new Hero("Ultron"));
            heroes.Add(new Hero("Venom"));
            return heroes;
        }
    }
}
