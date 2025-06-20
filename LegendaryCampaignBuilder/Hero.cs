using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryCampaignBuilder
{
    internal class Hero
    {
        string Name { get; }
        int Tier { get; }
        CompatibleCampaigns Campaigns {get;}
        HeroTeam Team { get; }
        Boolean FactionDependent { get; }
        HeroClass[] Classes { get; }
        Boolean ClassDependent { get; }
        Boolean IsPure { get; }
        Boolean CanKO { get; }
        Boolean CanHeal { get; }
        Boolean CanWound { get; }
    }
}
