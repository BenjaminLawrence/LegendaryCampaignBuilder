using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryCampaignBuilder
{
    internal class Hero
    {
        public string Name { get; }
        int Tier { get; }
        // CompatibleCampaigns Campaigns {get;}
        HeroTeam Team { get; }
        // Boolean FactionDependent { get; }
        HeroClass Classes { get; }
        // Boolean ClassDependent { get; }
        // Boolean IsPure { get; }
        // Boolean CanKO { get; }
        // Boolean CanHeal { get; }
        // Boolean CanWound { get; }

        public Hero(string name, int tier, HeroTeam team, HeroClass classes)
        {
            Name = name;
            Tier = tier;
            Team = team;
            Classes = classes;
        }

        public Hero(string name, int tier, HeroTeam team)
        {
            Name = name;
            Tier = tier;
            Team = team;
            Classes = (HeroClass)0;
        }

        public Hero(string name)
        {
            Name = name;
            Tier = 1;
            Team = HeroTeam.None;
            Classes = (HeroClass)0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
