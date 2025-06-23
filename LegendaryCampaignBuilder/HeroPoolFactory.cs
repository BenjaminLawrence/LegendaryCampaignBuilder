using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryCampaignBuilder
{
    internal class HeroPoolFactory
    {
        List<Hero> heroCatalog;

        public HeroPoolFactory(List<Hero> heroCatalog)
        {
            this.heroCatalog = heroCatalog;
        }

        public HeroPool ThunderboltHeroPool()
        {
            List<Hero> startingHeroPool = HeroSearch(new[] { "Blade", "Domino", "Elektra", "Ghost Rider", "Punisher", "Wolverine (X-Force)",
                                                             "Red Guardian", "Deadpool", "Agent Venom", "X-23", "Ronin", "Black Widow (Shield)" } );
            List<Hero> commonHeroPool = HeroSearch(new[] { "Hellcat", "Cable", "Forge", "Scarlet Spider", "Venom (Venomverse)", "War Machine",
                                                           "Moon Knight", "Deathlok", "Longshot", "Yelena Belova", "Symbiote Spider-Man", "White Tiger" });
            List<Hero> uncommonHeroPool = HeroSearch(new[] { "Bullseye", "Juggernaut", "Ultron", "Carnage", "Green Goblin", "Sentry" });
            return new HeroPool(startingHeroPool, commonHeroPool, uncommonHeroPool);
        }

        public HeroPool CosmosHeroPool()
        {
            List<Hero> startingHeroPool = HeroSearch(new[] { "Drax", "Gamora", "Groot", "Rocket Raccoon", "Star-Lord", "Nebula",
                                                             "Phyla-Vell", "Moondragon", "Quasar", "Hercules", "Nova (Avengers)", "Adam Warlock" });
            List<Hero> commonHeroPool = HeroSearch(new[] { "Captain Mar-Vell", "Thor (Asgard)", "Thing", "Agent Venom", "Yondu", "Supder-Skrull",
                                                           "Apocalyptic Kitty Pryde", "Superior Iron-Man", "Beta Ray Bill", "Ant-Man", "Fantastic Four United", "Silver Surfer" });
            List<Hero> uncommonHeroPool = HeroSearch(new[] { "Ronan the Acuser", "Heralds of Galactus", "Thanos", "Valkyrie", "The Warriors Three", "Lady Sif",
                                                             "Gladiator Hulk", "Korg", "Meek the Unhived", "Caiera", "Hiroim", "Skaar",
                                                             "Captain Marvel (Avengers)", "War Machine", "Nick Fury", "Wasp", "Venomized Rocket", "Lady Thor"});
            return new HeroPool(startingHeroPool, commonHeroPool, uncommonHeroPool);
        }

        private List<Hero> HeroSearch(string[] heroesToSearch)
        {
            List<Hero> heroesFound = new List<Hero>();
            foreach (string hero in heroesToSearch)
            {
                Hero? foundHero = heroCatalog.FirstOrDefault(Hero => Hero.Name == hero);
                if (foundHero != null)
                    heroesFound.Add(foundHero);
                else
                    Console.WriteLine("You do not own \"" + hero + "\"");
            }
            return heroesFound;
        }
    }
}
