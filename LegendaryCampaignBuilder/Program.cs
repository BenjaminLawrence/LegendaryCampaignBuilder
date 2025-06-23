// See https://aka.ms/new-console-template for more information
using LegendaryCampaignBuilder;
using LegendaryCampaignBuilder.Heroes;

// Check for expansion file
// If no save file exists
//  Ask for expansions
//  Add each expansion to file
// Go to menu
//  New Campaign
//    Go to campaign selection menu
//      Generate campaign
//  Load Campaign
//    Load specific campaign
//      Determine which campaign and stage
//        Continue generating
//  Expansions
//    Shows expansion list
//      Add expansion
//      Remove expansion
//  Settings
//    ???
//  Exit

// Expansions expansions = (Expansions)16628224;
Expansions expansions = (Expansions)511;
Catalog catalog = new Catalog(expansions);
HeroPoolFactory heroPoolFactory = new HeroPoolFactory(catalog.GetHeroes());
Console.WriteLine("Which campaign would you like to play?");
Console.WriteLine("1 - Thunderbolts");
Console.WriteLine("2 - Cosmos");
string choice = Console.ReadLine();
HeroPool heroPool = null;
if (choice == "1")
    heroPool = heroPoolFactory.ThunderboltHeroPool();
else if (choice == "2")
    heroPool = heroPoolFactory.CosmosHeroPool();
if (heroPool != null)
{
    List<Hero> startingHeroes = heroPool.GetStartingHeroes();
    Console.WriteLine("Your starting team is:");
    foreach (Hero hero in startingHeroes)
        Console.WriteLine(hero);
}
Console.WriteLine("Press enter to quit!");
Console.ReadLine();
