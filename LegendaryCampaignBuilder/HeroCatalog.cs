using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryCampaignBuilder
{
    internal class HeroCatalog
    {
        private List<Hero> _heroList = new List<Hero>();

        public HeroCatalog(Expansions expansions)
        {
            if ((expansions & Expansions.Core) != 0)
                _heroList.AddRange(GetCoreHeroes());
            if ((expansions & Expansions.FantasticFour) != 0)
                _heroList.AddRange(GetCoreHeroes());
            if ((expansions & Expansions.DarkCity) != 0)
                _heroList.AddRange(GetDarkCityHeroes());
            if ((expansions & Expansions.Villains) != 0)
                _heroList.AddRange(GetVillainsHeroes());
            if ((expansions & Expansions.PaintTheTownRed) != 0)
                _heroList.AddRange(GetPaintTheTownRedHeroes());
            if ((expansions & Expansions.GOTG) != 0)
                _heroList.AddRange(GetGOTGHeroes());
            if ((expansions & Expansions.FearItself) != 0)
                _heroList.AddRange(GetFearItselfHeroes());
            if ((expansions & Expansions.SecretWarsOne) != 0)
                _heroList.AddRange(GetSecretWarsOneHeroes());
            if ((expansions & Expansions.SecretWarsTwo) != 0)
                _heroList.AddRange(GetSecretWarsTwoHeroes());
        }

        public List<Hero> GetHeroes() { return _heroList; }

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

        public List<Hero> GetFantasticFourHeroes()
        {
            List<Hero> heroes = new List<Hero>();
            heroes.Add(new Hero("Human Torch"));
            heroes.Add(new Hero("Invisible Woman"));
            heroes.Add(new Hero("Mr. Fantastic"));
            heroes.Add(new Hero("Silver Surfer"));
            heroes.Add(new Hero("Thing"));
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

        public List<Hero> GetPaintTheTownRedHeroes()
        {
            List<Hero> heroes = new List<Hero>();
            heroes.Add(new Hero("Black Cat"));
            heroes.Add(new Hero("Moon Knight"));
            heroes.Add(new Hero("Scarlet Spider"));
            heroes.Add(new Hero("Spider-Woman"));
            heroes.Add(new Hero("Symbiote Spider-Man"));
            return heroes;
        }

        public List<Hero> GetGOTGHeroes()
        {
            List<Hero> heroes = new List<Hero>();
            heroes.Add(new Hero("Drax the Destroyer"));
            heroes.Add(new Hero("Gamora"));
            heroes.Add(new Hero("Groot"));
            heroes.Add(new Hero("Rocket Raccoon"));
            heroes.Add(new Hero("Star-Lord"));
            return heroes;
        }

        public List<Hero> GetFearItselfHeroes()
        {
            List<Hero> heroes = new List<Hero>();
            heroes.Add(new Hero("Greithoth, Breaker of Wills"));
            heroes.Add(new Hero("Kuurth, Breaker of Stone"));
            heroes.Add(new Hero("Nerkkod, Breaker of Oceans"));
            heroes.Add(new Hero("Nul, Breaker of Worlds"));
            heroes.Add(new Hero("Skadi"));
            heroes.Add(new Hero("Skirn, Breaker of Men"));
            return heroes;
        }

        public List<Hero> GetSecretWarsOneHeroes()
        {
            List<Hero> heroes = new List<Hero>();
            heroes.Add(new Hero("Apocalyptic Kitty Pryde"));
            heroes.Add(new Hero("Black Bolt"));
            heroes.Add(new Hero("Black Panther"));
            heroes.Add(new Hero("Captain Marvel"));
            heroes.Add(new Hero("Dr. Strange"));
            heroes.Add(new Hero("Lady Thor"));
            heroes.Add(new Hero("Magik"));
            heroes.Add(new Hero("Maximus"));
            heroes.Add(new Hero("Namor"));
            heroes.Add(new Hero("Old Man Logan"));
            heroes.Add(new Hero("Proxima Midnight"));
            heroes.Add(new Hero("Superior Iron Man"));
            heroes.Add(new Hero("Thanos"));
            heroes.Add(new Hero("Ultimate Spider-Man"));
            return heroes;
        }

        public List<Hero> GetSecretWarsTwoHeroes()
        {
            List<Hero> heroes = new List<Hero>();
            heroes.Add(new Hero("Agent Venom"));
            heroes.Add(new Hero("Arkon the Magnificent"));
            heroes.Add(new Hero("Beast"));
            heroes.Add(new Hero("Black Swan"));
            heroes.Add(new Hero("The Captain and the Devil"));
            heroes.Add(new Hero("Captain Britain"));
            heroes.Add(new Hero("Corvus Glaive"));
            heroes.Add(new Hero("Dr. Punisher the Soldier Supreme"));
            heroes.Add(new Hero("Elsa Bloodstone"));
            heroes.Add(new Hero("Phoenix Force Cyclops"));
            heroes.Add(new Hero("Ruby Summers"));
            heroes.Add(new Hero("Shang-Chi"));
            heroes.Add(new Hero("Silk"));
            heroes.Add(new Hero("Soulsword Colossus"));
            heroes.Add(new Hero("Spider-Gwen"));
            heroes.Add(new Hero("Time-Traveling Jean Grey"));
            return heroes;
        }
    }
}
