using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryCampaignBuilder.Heroes
{
    [Flags]
    enum HeroClass
    {
        Covert = 1,
        Instinct = 2,
        Ranged = 4,
        Strength = 8,
        Tech = 16
    }
}
