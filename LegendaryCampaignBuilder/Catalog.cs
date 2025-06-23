using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegendaryCampaignBuilder.Heroes;

namespace LegendaryCampaignBuilder
{
    internal class Catalog
    {
        private List<Hero> _heroList = new List<Hero>();
        private List<Mastermind> _mastermindList = new List<Mastermind>();
        private List<Scheme> _schemeList = new List<Scheme>();
        private List<VillainGroup> _villainGroupList = new List<VillainGroup>();
        private List<Henchmen> _henchmenList = new List<Henchmen>();

        public Catalog(Expansions expansions)
        {
            if ((expansions & Expansions.Core) != 0)
                AddCoreSet();
            if ((expansions & Expansions.FantasticFour) != 0)
                AddFantasticFourSet();
            if ((expansions & Expansions.DarkCity) != 0)
                AddDarkCitySet();
            if ((expansions & Expansions.Villains) != 0)
                AddVillainsSet();
            if ((expansions & Expansions.PaintTheTownRed) != 0)
                AddPaintTheTownRedSet();
            if ((expansions & Expansions.GOTG) != 0)
                AddGOTGSet();
            if ((expansions & Expansions.FearItself) != 0)
                AddFearItselfSet();
            if ((expansions & Expansions.SecretWarsOne) != 0)
                AddSecretWarsOneSet();
            if ((expansions & Expansions.SecretWarsTwo) != 0)
                AddSecretWarsTwoSet();
        }

        public List<Hero> GetHeroes() { return _heroList; }

        private void AddCoreSet()
        {
            // Heroes
            _heroList.Add(new Hero("Black Widow", 2, HeroTeam.Avengers, (HeroClass)17));
            _heroList.Add(new Hero("Captain America", 2, HeroTeam.Avengers, (HeroClass)27));
            _heroList.Add(new Hero("Cyclops", 1, HeroTeam.XMen, (HeroClass)12));
            _heroList.Add(new Hero("Deadpool", 1, HeroTeam.None, (HeroClass)19));
            _heroList.Add(new Hero("Emma Frost", 1, HeroTeam.XMen, (HeroClass)15));
            _heroList.Add(new Hero("Gambit", 1, HeroTeam.XMen, (HeroClass)7));
            _heroList.Add(new Hero("Hawkeye", 1, HeroTeam.Avengers, (HeroClass)18));
            _heroList.Add(new Hero("Hulk", 1, HeroTeam.Avengers, (HeroClass)10));
            _heroList.Add(new Hero("Iron Man", 1, HeroTeam.Avengers, (HeroClass)20));
            _heroList.Add(new Hero("Nick Fury", 1, HeroTeam.Shield, (HeroClass)25));
            _heroList.Add(new Hero("Rogue", 1, HeroTeam.XMen, (HeroClass)9));
            _heroList.Add(new Hero("Spider-Man", 1, HeroTeam.SpiderFriends, (HeroClass)27));
            _heroList.Add(new Hero("Storm", 1, HeroTeam.XMen, (HeroClass)6));
            _heroList.Add(new Hero("Thor", 1, HeroTeam.Avengers, (HeroClass)12));
            _heroList.Add(new Hero("Wolverine", 1, HeroTeam.XMen, (HeroClass)2));
        }

        private void AddFantasticFourSet()
        {
            // Heroes
            _heroList.Add(new Hero("Human Torch"));
            _heroList.Add(new Hero("Invisible Woman"));
            _heroList.Add(new Hero("Mr. Fantastic"));
            _heroList.Add(new Hero("Silver Surfer"));
            _heroList.Add(new Hero("Thing"));
        }

        private void AddDarkCitySet()
        {
            // Heroes
            _heroList.Add(new Hero("Angel", 1, HeroTeam.XMen, (HeroClass)11));
            _heroList.Add(new Hero("Bishop", 1, HeroTeam.XMen, (HeroClass)21));
            _heroList.Add(new Hero("Blade", 1, HeroTeam.MarvelKnights, (HeroClass)27));
            _heroList.Add(new Hero("Cable", 1, HeroTeam.XForce, (HeroClass)21));
            _heroList.Add(new Hero("Colossus", 1, HeroTeam.XForce, (HeroClass)9));
            _heroList.Add(new Hero("Daredevil", 1, HeroTeam.MarvelKnights, (HeroClass)11));
            _heroList.Add(new Hero("Domino", 2, HeroTeam.XForce));
            _heroList.Add(new Hero("Elektra", 1, HeroTeam.MarvelKnights));
            _heroList.Add(new Hero("Forge", 1, HeroTeam.XForce));
            _heroList.Add(new Hero("Ghost Rider", 1, HeroTeam.MarvelKnights));
            _heroList.Add(new Hero("Iceman", 2, HeroTeam.XMen));
            _heroList.Add(new Hero("Iron Fist", 1, HeroTeam.MarvelKnights));
            _heroList.Add(new Hero("Jean Grey", 1, HeroTeam.XMen));
            _heroList.Add(new Hero("Nightcrawler", 1, HeroTeam.XMen));
            _heroList.Add(new Hero("Professor X", 1, HeroTeam.XMen));
            _heroList.Add(new Hero("Punisher", 1, HeroTeam.MarvelKnights));
            _heroList.Add(new Hero("Wolverine (X-Force)", 1, HeroTeam.XForce));
        }

        private void AddVillainsSet()
        {
            // Heroes
            _heroList.Add(new Hero("Bullseye"));
            _heroList.Add(new Hero("Dr. Octopus"));
            _heroList.Add(new Hero("Electro"));
            _heroList.Add(new Hero("Enchantress"));
            _heroList.Add(new Hero("Green Goblin"));
            _heroList.Add(new Hero("Juggernaut"));
            _heroList.Add(new Hero("Kingpin"));
            _heroList.Add(new Hero("Kraven"));
            _heroList.Add(new Hero("Loki"));
            _heroList.Add(new Hero("Magneto"));
            _heroList.Add(new Hero("Mysterio"));
            _heroList.Add(new Hero("Mystique"));
            _heroList.Add(new Hero("Sabretooth"));
            _heroList.Add(new Hero("Ultron"));
            _heroList.Add(new Hero("Venom"));
        }

        private void AddPaintTheTownRedSet()
        {
            // Heroes
            _heroList.Add(new Hero("Black Cat"));
            _heroList.Add(new Hero("Moon Knight"));
            _heroList.Add(new Hero("Scarlet Spider"));
            _heroList.Add(new Hero("Spider-Woman"));
            _heroList.Add(new Hero("Symbiote Spider-Man"));
        }

        private void AddGOTGSet()
        {
            // Heroes
            _heroList.Add(new Hero("Drax the Destroyer"));
            _heroList.Add(new Hero("Gamora"));
            _heroList.Add(new Hero("Groot"));
            _heroList.Add(new Hero("Rocket Raccoon"));
            _heroList.Add(new Hero("Star-Lord"));
        }

        private void AddFearItselfSet()
        {
            // Heroes
            _heroList.Add(new Hero("Greithoth, Breaker of Wills"));
            _heroList.Add(new Hero("Kuurth, Breaker of Stone"));
            _heroList.Add(new Hero("Nerkkod, Breaker of Oceans"));
            _heroList.Add(new Hero("Nul, Breaker of Worlds"));
            _heroList.Add(new Hero("Skadi"));
            _heroList.Add(new Hero("Skirn, Breaker of Men"));
        }

        private void AddSecretWarsOneSet()
        {
            // Heroes
            _heroList.Add(new Hero("Apocalyptic Kitty Pryde"));
            _heroList.Add(new Hero("Black Bolt"));
            _heroList.Add(new Hero("Black Panther"));
            _heroList.Add(new Hero("Captain Marvel"));
            _heroList.Add(new Hero("Dr. Strange"));
            _heroList.Add(new Hero("Lady Thor"));
            _heroList.Add(new Hero("Magik"));
            _heroList.Add(new Hero("Maximus"));
            _heroList.Add(new Hero("Namor"));
            _heroList.Add(new Hero("Old Man Logan"));
            _heroList.Add(new Hero("Proxima Midnight"));
            _heroList.Add(new Hero("Superior Iron Man"));
            _heroList.Add(new Hero("Thanos"));
            _heroList.Add(new Hero("Ultimate Spider-Man"));
        }

        private void AddSecretWarsTwoSet()
        {
            // Heroes
            _heroList.Add(new Hero("Agent Venom"));
            _heroList.Add(new Hero("Arkon the Magnificent"));
            _heroList.Add(new Hero("Beast"));
            _heroList.Add(new Hero("Black Swan"));
            _heroList.Add(new Hero("The Captain and the Devil"));
            _heroList.Add(new Hero("Captain Britain"));
            _heroList.Add(new Hero("Corvus Glaive"));
            _heroList.Add(new Hero("Dr. Punisher the Soldier Supreme"));
            _heroList.Add(new Hero("Elsa Bloodstone"));
            _heroList.Add(new Hero("Phoenix Force Cyclops"));
            _heroList.Add(new Hero("Ruby Summers"));
            _heroList.Add(new Hero("Shang-Chi"));
            _heroList.Add(new Hero("Silk"));
            _heroList.Add(new Hero("Soulsword Colossus"));
            _heroList.Add(new Hero("Spider-Gwen"));
            _heroList.Add(new Hero("Time-Traveling Jean Grey"));
        }
    }
}
