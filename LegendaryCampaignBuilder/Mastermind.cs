using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryCampaignBuilder
{
    internal class Mastermind
    {
        string Name { get; }
        int Tier { get; }
        Difficulty Difficulty { get; }
        HeroTeam[] TeamsThatMatter { get; }
        HeroClass[] ClassesThatMatter { get; }
    }
}
