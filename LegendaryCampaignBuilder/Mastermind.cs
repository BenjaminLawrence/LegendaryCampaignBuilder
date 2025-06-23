using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegendaryCampaignBuilder.Heroes;

namespace LegendaryCampaignBuilder
{
    internal class Mastermind
    {
        string Name { get; }
        int Tier { get; }
        Difficulty Difficulty { get; }
        HeroTeam[]? TeamsThatMatter { get; }
        HeroClass[]? ClassesThatMatter { get; }

        public Mastermind(string name)
        {
            Name = name;
            Tier = 0;
            Difficulty = Difficulty.Easy;
            TeamsThatMatter = null;
            ClassesThatMatter = null;
        }
    }
}
