using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegendaryCampaignBuilder.Heroes;

namespace LegendaryCampaignBuilder
{
    internal class Catalog
    {
        private List<Hero> _heroList = new List<Hero>();
        private List<Mastermind> _mastermindList = new List<Mastermind>();
        private List<VillainGroup> _villainGroupList = new List<VillainGroup>();
        private List<Henchmen> _henchmenList = new List<Henchmen>();
        private List<Scheme> _schemeList = new List<Scheme>();

        public Catalog(Expansions expansions)
        {
            if ((expansions & Expansions.Core) != 0)
                AddCoreSet();
            if ((expansions & Expansions.FantasticFour) != 0)
                AddFantasticFourSet();
            if ((expansions & Expansions.DarkCity) != 0)
                AddDarkCitySet();
            if ((expansions & Expansions.Villains) != 0)
                AddVillainsSet();
            if ((expansions & Expansions.PaintTheTownRed) != 0)
                AddPaintTheTownRedSet();
            if ((expansions & Expansions.GOTG) != 0)
                AddGOTGSet();
            if ((expansions & Expansions.FearItself) != 0)
                AddFearItselfSet();
            if ((expansions & Expansions.SecretWarsOne) != 0)
                AddSecretWarsOneSet();
            if ((expansions & Expansions.SecretWarsTwo) != 0)
                AddSecretWarsTwoSet();
            if ((expansions & Expansions.CaptainAmerica) != 0)
                AddCaptainAmericaSet();
            if ((expansions & Expansions.CivilWar) != 0)
                AddCivilWarSet();
            if ((expansions & Expansions.Deadpool) != 0)
                AddDeadpoolSet();
            if ((expansions & Expansions.Noir) != 0)
                AddNoirSet();
            if ((expansions & Expansions.XMen) != 0)
                AddXMenSet();
            if ((expansions & Expansions.Homecoming) != 0)
                AddHomecomingSet();
        }

        public List<Hero> GetHeroes() { return _heroList; }

        private void AddCoreSet()
        {
            // Heroes
            _heroList.Add(new Hero("Black Widow", 2, HeroTeam.Avengers, (HeroClass)17));
            _heroList.Add(new Hero("Captain America", 2, HeroTeam.Avengers, (HeroClass)27));
            _heroList.Add(new Hero("Cyclops", 1, HeroTeam.XMen, (HeroClass)12));
            _heroList.Add(new Hero("Deadpool", 1, HeroTeam.None, (HeroClass)19));
            _heroList.Add(new Hero("Emma Frost", 1, HeroTeam.XMen, (HeroClass)15));
            _heroList.Add(new Hero("Gambit", 1, HeroTeam.XMen, (HeroClass)7));
            _heroList.Add(new Hero("Hawkeye", 1, HeroTeam.Avengers, (HeroClass)18));
            _heroList.Add(new Hero("Hulk", 1, HeroTeam.Avengers, (HeroClass)10));
            _heroList.Add(new Hero("Iron Man", 1, HeroTeam.Avengers, (HeroClass)20));
            _heroList.Add(new Hero("Nick Fury", 1, HeroTeam.Shield, (HeroClass)25));
            _heroList.Add(new Hero("Rogue", 1, HeroTeam.XMen, (HeroClass)9));
            _heroList.Add(new Hero("Spider-Man", 1, HeroTeam.SpiderFriends, (HeroClass)27));
            _heroList.Add(new Hero("Storm", 1, HeroTeam.XMen, (HeroClass)6));
            _heroList.Add(new Hero("Thor", 1, HeroTeam.Avengers, (HeroClass)12));
            _heroList.Add(new Hero("Wolverine", 1, HeroTeam.XMen, (HeroClass)2));

            // Masterminds
            _mastermindList.Add(new Mastermind("Dr. Doom"));
            _mastermindList.Add(new Mastermind("Loki"));
            _mastermindList.Add(new Mastermind("Magneto"));
            _mastermindList.Add(new Mastermind("Red Skull"));

            // Villain Groups
            _villainGroupList.Add(new VillainGroup("Brotherhood"));
            _villainGroupList.Add(new VillainGroup("Enemies of Asgard"));
            _villainGroupList.Add(new VillainGroup("Hydra"));
            _villainGroupList.Add(new VillainGroup("Masters of Evil"));
            _villainGroupList.Add(new VillainGroup("Radiation"));
            _villainGroupList.Add(new VillainGroup("Skrulls"));
            _villainGroupList.Add(new VillainGroup("Spider-Foes"));

            // Henchmen
            _henchmenList.Add(new Henchmen("Doombot Legion"));
            _henchmenList.Add(new Henchmen("Hand Ninjas"));
            _henchmenList.Add(new Henchmen("Savage Land Mutates"));
            _henchmenList.Add(new Henchmen("Sentinel"));

            // Schemes
            _schemeList.Add(new Scheme("The Legacy Virus"));
            _schemeList.Add(new Scheme("Midtown Bank Robbery"));
            _schemeList.Add(new Scheme("Negative Zone Prison Breakout"));
            _schemeList.Add(new Scheme("Portals to the Dark Dimension"));
            _schemeList.Add(new Scheme("Replace Earth's Leaders with Killbots"));
            _schemeList.Add(new Scheme("Secret Invasion of the Skrull Shapeshifters"));
            _schemeList.Add(new Scheme("Super Hero Civil War"));
            _schemeList.Add(new Scheme("Unleash the Power of the Cosmic Cube"));
        }

        private void AddFantasticFourSet()
        {
            // Heroes
            _heroList.Add(new Hero("Human Torch"));
            _heroList.Add(new Hero("Invisible Woman"));
            _heroList.Add(new Hero("Mr. Fantastic"));
            _heroList.Add(new Hero("Silver Surfer"));
            _heroList.Add(new Hero("Thing"));

            // Masterminds
            _mastermindList.Add(new Mastermind("Galactus"));
            _mastermindList.Add(new Mastermind("Mole Man"));

            // Villain Groups
            _villainGroupList.Add(new VillainGroup("Heralds of Galactus"));
            _villainGroupList.Add(new VillainGroup("Subterranea"));

            // Schemes
            _schemeList.Add(new Scheme("Bathe Earth in Cosmic Rays"));
            _schemeList.Add(new Scheme("Flood the Planet with Melted Glaciers"));
            _schemeList.Add(new Scheme("Invincible Force Field"));
            _schemeList.Add(new Scheme("Pull Reality into the Negative Zone"));
        }

        private void AddDarkCitySet()
        {
            // Heroes
            _heroList.Add(new Hero("Angel", 1, HeroTeam.XMen, (HeroClass)11));
            _heroList.Add(new Hero("Bishop", 1, HeroTeam.XMen, (HeroClass)21));
            _heroList.Add(new Hero("Blade", 1, HeroTeam.MarvelKnights, (HeroClass)27));
            _heroList.Add(new Hero("Cable", 1, HeroTeam.XForce, (HeroClass)21));
            _heroList.Add(new Hero("Colossus", 1, HeroTeam.XForce, (HeroClass)9));
            _heroList.Add(new Hero("Daredevil", 1, HeroTeam.MarvelKnights, (HeroClass)11));
            _heroList.Add(new Hero("Domino", 2, HeroTeam.XForce));
            _heroList.Add(new Hero("Elektra", 1, HeroTeam.MarvelKnights));
            _heroList.Add(new Hero("Forge", 1, HeroTeam.XForce));
            _heroList.Add(new Hero("Ghost Rider", 1, HeroTeam.MarvelKnights));
            _heroList.Add(new Hero("Iceman", 2, HeroTeam.XMen));
            _heroList.Add(new Hero("Iron Fist", 1, HeroTeam.MarvelKnights));
            _heroList.Add(new Hero("Jean Grey", 1, HeroTeam.XMen));
            _heroList.Add(new Hero("Nightcrawler", 1, HeroTeam.XMen));
            _heroList.Add(new Hero("Professor X", 1, HeroTeam.XMen));
            _heroList.Add(new Hero("Punisher", 1, HeroTeam.MarvelKnights));
            _heroList.Add(new Hero("Wolverine (X-Force)", 1, HeroTeam.XForce));

            // Masterminds
            _mastermindList.Add(new Mastermind("Apocalypse"));
            _mastermindList.Add(new Mastermind("Kingpin"));
            _mastermindList.Add(new Mastermind("Mephisto"));
            _mastermindList.Add(new Mastermind("Mr. Sinister"));
            _mastermindList.Add(new Mastermind("Stryfe"));

            // Villain Groups
            _villainGroupList.Add(new VillainGroup("Emissaries of Evil"));
            _villainGroupList.Add(new VillainGroup("Four Horseman"));
            _villainGroupList.Add(new VillainGroup("Marauders"));
            _villainGroupList.Add(new VillainGroup("MLF"));
            _villainGroupList.Add(new VillainGroup("Streets of New York"));
            _villainGroupList.Add(new VillainGroup("Underworld"));
            _villainGroupList.Add(new VillainGroup("Spider-Foes"));

            // Henchmen
            _henchmenList.Add(new Henchmen("Maggia Goons"));
            _henchmenList.Add(new Henchmen("Phalanx"));

            // Schemes
            _schemeList.Add(new Scheme("Capture Baby Hope"));
            _schemeList.Add(new Scheme("Detonate the Helicarrier"));
            _schemeList.Add(new Scheme("Massive Earthquake Generator"));
            _schemeList.Add(new Scheme("Organized Crime Wave"));
            _schemeList.Add(new Scheme("Save Humanity"));
            _schemeList.Add(new Scheme("Steal the Weaponized Plutonium"));
            _schemeList.Add(new Scheme("Transform Citizens into Demons"));
            _schemeList.Add(new Scheme("X-Cutioner's Song"));
        }

        private void AddVillainsSet()
        {
            // Heroes
            _heroList.Add(new Hero("Bullseye"));
            _heroList.Add(new Hero("Dr. Octopus"));
            _heroList.Add(new Hero("Electro"));
            _heroList.Add(new Hero("Enchantress"));
            _heroList.Add(new Hero("Green Goblin"));
            _heroList.Add(new Hero("Juggernaut"));
            _heroList.Add(new Hero("Kingpin"));
            _heroList.Add(new Hero("Kraven"));
            _heroList.Add(new Hero("Loki"));
            _heroList.Add(new Hero("Magneto"));
            _heroList.Add(new Hero("Mysterio"));
            _heroList.Add(new Hero("Mystique"));
            _heroList.Add(new Hero("Sabretooth"));
            _heroList.Add(new Hero("Ultron"));
            _heroList.Add(new Hero("Venom"));

            // Masterminds
            _mastermindList.Add(new Mastermind("Dr. Strange"));
            _mastermindList.Add(new Mastermind("Nick Fury"));
            _mastermindList.Add(new Mastermind("Odin"));
            _mastermindList.Add(new Mastermind("Professor X"));

            // Villain Groups
            _villainGroupList.Add(new VillainGroup("Avengers"));
            _villainGroupList.Add(new VillainGroup("Defenders"));
            _villainGroupList.Add(new VillainGroup("Marvel Knights"));
            _villainGroupList.Add(new VillainGroup("Spider Friends"));
            _villainGroupList.Add(new VillainGroup("Uncanny Avengers"));
            _villainGroupList.Add(new VillainGroup("Uncanny X-Men"));
            _villainGroupList.Add(new VillainGroup("X-Men First Class"));

            // Henchmen
            _henchmenList.Add(new Henchmen("Cops"));
            _henchmenList.Add(new Henchmen("Multiple Man"));
            _henchmenList.Add(new Henchmen("SHIELD Assault Squad"));
            _henchmenList.Add(new Henchmen("Asgardian Warrior"));

            // Schemes
            _schemeList.Add(new Scheme("Build an Underground Mega-Vault Prison"));
            _schemeList.Add(new Scheme("Cage Villains in Power-Supressing Cells"));
            _schemeList.Add(new Scheme("Crown Thor King of Asgard"));
            _schemeList.Add(new Scheme("Crush Hydra"));
            _schemeList.Add(new Scheme("Graduation at Xavier's X-Academy"));
            _schemeList.Add(new Scheme("Infiltrate the Lair with Spies"));
            _schemeList.Add(new Scheme("Mass Produce War Machine Armor"));
            _schemeList.Add(new Scheme("Resurrect Heroes with the Norn Stones"));
        }

        private void AddPaintTheTownRedSet()
        {
            // Heroes
            _heroList.Add(new Hero("Black Cat"));
            _heroList.Add(new Hero("Moon Knight"));
            _heroList.Add(new Hero("Scarlet Spider"));
            _heroList.Add(new Hero("Spider-Woman"));
            _heroList.Add(new Hero("Symbiote Spider-Man"));

            // Masterminds
            _mastermindList.Add(new Mastermind("Carnage"));
            _mastermindList.Add(new Mastermind("Mysterio"));

            // Villain Groups
            _villainGroupList.Add(new VillainGroup("Maximum Carnage"));
            _villainGroupList.Add(new VillainGroup("Sinister Six"));

            // Schemes
            _schemeList.Add(new Scheme("The Clone Saga"));
            _schemeList.Add(new Scheme("Invade the Daily Bugle News HQ"));
            _schemeList.Add(new Scheme("Splice Humans with Spider DNA"));
            _schemeList.Add(new Scheme("Weave a Web of Lies"));
        }

        private void AddGOTGSet()
        {
            // Heroes
            _heroList.Add(new Hero("Drax the Destroyer"));
            _heroList.Add(new Hero("Gamora"));
            _heroList.Add(new Hero("Groot"));
            _heroList.Add(new Hero("Rocket Raccoon"));
            _heroList.Add(new Hero("Star-Lord"));

            // Masterminds
            _mastermindList.Add(new Mastermind("Supreme Intelligence of the Kree"));
            _mastermindList.Add(new Mastermind("Thanos"));

            // Villain Groups
            _villainGroupList.Add(new VillainGroup("Infinity Gems"));
            _villainGroupList.Add(new VillainGroup("Kree Starforce"));

            // Schemes
            _schemeList.Add(new Scheme("Forge the Infinity Gauntlet"));
            _schemeList.Add(new Scheme("Intergalactic Kree Nega-Bomb"));
            _schemeList.Add(new Scheme("The Kree-Skrull War"));
            _schemeList.Add(new Scheme("Unite the Shards"));
        }

        private void AddFearItselfSet()
        {
            // Heroes
            _heroList.Add(new Hero("Greithoth, Breaker of Wills"));
            _heroList.Add(new Hero("Kuurth, Breaker of Stone"));
            _heroList.Add(new Hero("Nerkkod, Breaker of Oceans"));
            _heroList.Add(new Hero("Nul, Breaker of Worlds"));
            _heroList.Add(new Hero("Skadi"));
            _heroList.Add(new Hero("Skirn, Breaker of Men"));
            
            // Masterminds
            _mastermindList.Add(new Mastermind("Uru-Enchanted Iron Man"));

            // Villain Groups
            _villainGroupList.Add(new VillainGroup("The Mighty"));

            // Schemes
            _schemeList.Add(new Scheme("Last Stand at Avengers Tower"));
            _schemeList.Add(new Scheme("Fear Itself"));
            _schemeList.Add(new Scheme("The Traitor"));
        }

        private void AddSecretWarsOneSet()
        {
            // Heroes
            _heroList.Add(new Hero("Apocalyptic Kitty Pryde"));
            _heroList.Add(new Hero("Black Bolt"));
            _heroList.Add(new Hero("Black Panther"));
            _heroList.Add(new Hero("Captain Marvel"));
            _heroList.Add(new Hero("Dr. Strange"));
            _heroList.Add(new Hero("Lady Thor"));
            _heroList.Add(new Hero("Magik"));
            _heroList.Add(new Hero("Maximus"));
            _heroList.Add(new Hero("Namor"));
            _heroList.Add(new Hero("Old Man Logan"));
            _heroList.Add(new Hero("Proxima Midnight"));
            _heroList.Add(new Hero("Superior Iron Man"));
            _heroList.Add(new Hero("Thanos"));
            _heroList.Add(new Hero("Ultimate Spider-Man"));

            // Masterminds
            _mastermindList.Add(new Mastermind("Madelyne Pryor, Goblin Queen"));
            _mastermindList.Add(new Mastermind("Nimrod, Super Sentinel"));
            _mastermindList.Add(new Mastermind("Wasteland Hulk"));
            _mastermindList.Add(new Mastermind("Zombie Green Goblin"));

            // Villain Groups
            _villainGroupList.Add(new VillainGroup("The Deadlands"));
            _villainGroupList.Add(new VillainGroup("Domains of Apocalypse"));
            _villainGroupList.Add(new VillainGroup("Limbo"));
            _villainGroupList.Add(new VillainGroup("Manhattan (Earth-1610)"));
            _villainGroupList.Add(new VillainGroup("Sentinel Territories"));
            _villainGroupList.Add(new VillainGroup("Wasteland"));

            // Henchmen
            _henchmenList.Add(new Henchmen("Thor Corps"));
            _henchmenList.Add(new Henchmen("Ghost Racers"));
            _henchmenList.Add(new Henchmen("MODOKS"));

            // Schemes
            _schemeList.Add(new Scheme("Build an Army of Annihilation"));
            _schemeList.Add(new Scheme("Corrupt the Next Generation of Heroes"));
            _schemeList.Add(new Scheme("Crush them with my Bare Hands"));
            _schemeList.Add(new Scheme("Dark Alliance"));
            _schemeList.Add(new Scheme("Fragmented Realities"));
            _schemeList.Add(new Scheme("Master of Tyrants"));
            _schemeList.Add(new Scheme("Pan-Dimensional Plague"));
            _schemeList.Add(new Scheme("Smash Two Dimensions Together"));
        }

        private void AddSecretWarsTwoSet()
        {
            // Heroes
            _heroList.Add(new Hero("Agent Venom"));
            _heroList.Add(new Hero("Arkon the Magnificent"));
            _heroList.Add(new Hero("Beast"));
            _heroList.Add(new Hero("Black Swan"));
            _heroList.Add(new Hero("The Captain and the Devil"));
            _heroList.Add(new Hero("Captain Britain"));
            _heroList.Add(new Hero("Corvus Glaive"));
            _heroList.Add(new Hero("Dr. Punisher the Soldier Supreme"));
            _heroList.Add(new Hero("Elsa Bloodstone"));
            _heroList.Add(new Hero("Phoenix Force Cyclops"));
            _heroList.Add(new Hero("Ruby Summers"));
            _heroList.Add(new Hero("Shang-Chi"));
            _heroList.Add(new Hero("Silk"));
            _heroList.Add(new Hero("Soulsword Colossus"));
            _heroList.Add(new Hero("Spider-Gwen"));
            _heroList.Add(new Hero("Time-Traveling Jean Grey"));

            // Masterminds
            _mastermindList.Add(new Mastermind("Immortal Emperor Zheng-Zhu"));
            _mastermindList.Add(new Mastermind("King Hyperion"));
            _mastermindList.Add(new Mastermind("Shiklah, the Demon Bride"));
            _mastermindList.Add(new Mastermind("Spider Queen"));

            // Villain Groups
            _villainGroupList.Add(new VillainGroup("Deadpool's Secret Secret Wars"));
            _villainGroupList.Add(new VillainGroup("Guardians of Knowhere"));
            _villainGroupList.Add(new VillainGroup("K'un Lun"));
            _villainGroupList.Add(new VillainGroup("Monster Metropolis"));
            _villainGroupList.Add(new VillainGroup("Utopolis"));
            _villainGroupList.Add(new VillainGroup("X-Men '92"));

            // Henchmen
            _henchmenList.Add(new Henchmen("Khonshu Guardians"));
            _henchmenList.Add(new Henchmen("Magma Men"));
            _henchmenList.Add(new Henchmen("Spider-Infected"));

            // Schemes
            _schemeList.Add(new Scheme("Deadlands Hordes Charge the Wall"));
            _schemeList.Add(new Scheme("Enthrone the Barons of Battleworld"));
            _schemeList.Add(new Scheme("The Fountain of Eternal Life"));
            _schemeList.Add(new Scheme("The God-Emperor of Battleworld"));
            _schemeList.Add(new Scheme("The Mark of Khonshu"));
            _schemeList.Add(new Scheme("Master the Mysteries of Kung-Fu"));
            _schemeList.Add(new Scheme("Secret Wars"));
            _schemeList.Add(new Scheme("Sinister Ambitions"));
        }

        private void AddCaptainAmericaSet()
        {
            // TODO
        }

        private void AddDeadpoolSet()
        {
            // TODO
        }

        private void AddCivilWarSet()
        {
            // Heroes
            _heroList.Add(new Hero("Captain America, Secret Avenger"));
            _heroList.Add(new Hero("Cloak & Dagger"));
            _heroList.Add(new Hero("Daredevil"));
            _heroList.Add(new Hero("Falcon"));
            _heroList.Add(new Hero("Goliath"));
            _heroList.Add(new Hero("Hercules"));
            _heroList.Add(new Hero("Hulkling"));
            _heroList.Add(new Hero("Luke Cage"));
            _heroList.Add(new Hero("Patriot"));
            _heroList.Add(new Hero("Peter Parker"));
            _heroList.Add(new Hero("Speedball"));
            _heroList.Add(new Hero("Stature"));
            _heroList.Add(new Hero("Storm & Black Panther"));
            _heroList.Add(new Hero("Tigra"));
            _heroList.Add(new Hero("Vision"));
            _heroList.Add(new Hero("Wiccan"));

            // Masterminds
            _mastermindList.Add(new Mastermind("Authoritarian Iron Man"));
            _mastermindList.Add(new Mastermind("Baron Helmut Zemo"));
            _mastermindList.Add(new Mastermind("Maria Hill, Director of SHIELD"));
            _mastermindList.Add(new Mastermind("Misty Knight"));
            _mastermindList.Add(new Mastermind("Ragnarok"));

            // Villain Groups
            _villainGroupList.Add(new VillainGroup("CSA Special Marshals"));
            _villainGroupList.Add(new VillainGroup("Great Lake Avengers"));
            _villainGroupList.Add(new VillainGroup("Heroes for Hire"));
            _villainGroupList.Add(new VillainGroup("Registration Enforcers"));
            _villainGroupList.Add(new VillainGroup("SHIELD Elite"));
            _villainGroupList.Add(new VillainGroup("Superhuman Registration Act"));
            _villainGroupList.Add(new VillainGroup("Thunderbolts"));

            // Henchmen
            _henchmenList.Add(new Henchmen("Cape-Killers"));
            _henchmenList.Add(new Henchmen("Mandroid"));

            // Schemes
            _schemeList.Add(new Scheme("Avengers vs. X-Men"));
            _schemeList.Add(new Scheme("Dark Reign of HAMMER Officers"));
            _schemeList.Add(new Scheme("Epic Super Hero Civil War"));
            _schemeList.Add(new Scheme("Imprison Unregistered Superhumans"));
            _schemeList.Add(new Scheme("Nitro the Supervillain Threatens Crowds"));
            _schemeList.Add(new Scheme("Predict Future Crime"));
            _schemeList.Add(new Scheme("Reveal Heroes' Secret Identities"));
            _schemeList.Add(new Scheme("United States Split by Civil War"));
        }
    }
}
