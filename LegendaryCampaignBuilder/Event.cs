using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegendaryCampaignBuilder.Cards;

namespace LegendaryCampaignBuilder
{
    internal class Event
    {
        Mastermind Mastermind { get; set; }
        Scheme Scheme { get; set; }
        Hero Reward { get; set; }

        public string Name { get; set; }
    }
}
