// See https://aka.ms/new-console-template for more information
using LegendaryCampaignBuilder;

// Expansions expansions = (Expansions)16628224;
Expansions expansions = (Expansions)511;
HeroCatalog heroCatalog = new HeroCatalog(expansions);
HeroPoolFactory heroPoolFactory = new HeroPoolFactory(heroCatalog.GetHeroes());
HeroPool heroPool = heroPoolFactory.ThunderboltHeroPool();
List<Hero> startingHeroes = heroPool.GetStartingHeroes();
Console.WriteLine("Your starting team is:");
foreach (Hero hero in startingHeroes)
    Console.WriteLine(hero);
Console.WriteLine("Press enter to quit!");
Console.ReadLine();
