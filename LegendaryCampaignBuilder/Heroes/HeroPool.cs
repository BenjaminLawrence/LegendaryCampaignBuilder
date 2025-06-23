using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LegendaryCampaignBuilder.Heroes
{
    internal class HeroPool
    {
        List<Hero> startingHeroPool;
        List<Hero> commonHeroPool;
        List<Hero> uncommonHeroPool;
        // List<Hero> rareHeroPool;

        public HeroPool(List<Hero> startingHeroPool, List<Hero> commonHeroPool, List<Hero> uncommonHeroPool)
        {
            this.startingHeroPool = startingHeroPool;
            this.commonHeroPool = commonHeroPool;
            this.uncommonHeroPool = uncommonHeroPool;
        }

        public List<Hero> GetStartingHeroes()
        {
            List<Hero> startingHeroes = new List<Hero>();
            for (int i = 0; i < 5; i++)
                startingHeroes.Add(PullHero(startingHeroPool));
            commonHeroPool.AddRange(startingHeroPool);
            return startingHeroes;
        }

        private Hero PullHero(List<Hero> heroPool)
        {
            Random rnd = new Random();
            int index = rnd.Next(heroPool.Count);
            Hero pull = heroPool[index];
            heroPool.Remove(pull);
            return pull;
        }
    }
}
