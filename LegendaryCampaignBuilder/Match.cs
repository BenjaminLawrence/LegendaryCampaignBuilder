﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryCampaignBuilder
{
    internal class Match
    {
        List<Hero> Heroes { get; }
        Mastermind Mastermind { get; }
        Scheme Scheme { get; }
        List<VillainGroup> VillainGroups { get; }
        List<Henchmen> HenchmenGroups { get; }
    }
}
