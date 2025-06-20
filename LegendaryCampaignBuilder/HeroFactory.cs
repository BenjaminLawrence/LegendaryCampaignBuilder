using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryCampaignBuilder
{
    internal class HeroFactory
    {
        // Covert = 1, Instinct = 2, Ranged = 4, Strength = 8, Tech = 16
        public Hero[] GetCoreGameHeroes()
        {
            Hero blackWidow = new Hero("Black Widow", 2, HeroTeam.Avengers, (HeroClass) 17);
            Hero captainAmerica = new Hero("Captain America", 2, HeroTeam.Avengers, (HeroClass) 27);
            Hero cyclops = new Hero("Cyclops", 1, HeroTeam.XMen, (HeroClass) 12);
            Hero deadpool = new Hero("Deadpool", 1, HeroTeam.None, (HeroClass) 19);
            Hero emmaFrost = new Hero("Emma Frost", 1, HeroTeam.XMen, (HeroClass) 15);
            Hero gambit = new Hero("Gambit", 1, HeroTeam.XMen, (HeroClass) 7);
            Hero hawkeye = new Hero("Hawkeye", 1, HeroTeam.Avengers, (HeroClass) 18);
            Hero hulk = new Hero("Hulk", 1, HeroTeam.Avengers, (HeroClass) 10);
            Hero ironMan = new Hero("Iron Man", 1, HeroTeam.Avengers, (HeroClass) 20);
            Hero nickFury = new Hero("Nick Fury", 1, HeroTeam.Shield, (HeroClass) 25);
            Hero rogue = new Hero("Rogue", 1, HeroTeam.XMen, (HeroClass) 9);
            Hero spiderMan = new Hero("Spider-Man", 1, HeroTeam.SpiderFriends, (HeroClass) 27);
            Hero storm = new Hero("Storm", 1, HeroTeam.XMen, (HeroClass) 6);
            Hero thor = new Hero("Thor", 1, HeroTeam.Avengers, (HeroClass) 12);
            Hero wolverine = new Hero("Wolverine", 1, HeroTeam.XMen, (HeroClass) 2);
            Hero[] heroArray = { blackWidow };
            return heroArray;
        }
    }
}
