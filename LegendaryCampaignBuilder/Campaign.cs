using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegendaryCampaignBuilder.Heroes;

namespace LegendaryCampaignBuilder
{
    internal class Campaign
    {
        string Name { get; }
        List<Hero> HeroPool { get; }
        List<Mastermind> MastermindPool { get; }
        List<VillainGroup> VillainPool { get; }
        List<Henchmen> HenchmenPool { get; }
    }
}
