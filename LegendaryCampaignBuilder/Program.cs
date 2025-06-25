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

Expansions expansions = (Expansions)511;
Catalog catalog = new Catalog(expansions);
OutputHandler outputHandler = new OutputHandler();
HeroPoolFactory heroPoolFactory = new HeroPoolFactory(catalog.GetHeroes());
HeroPool heroPool = null;

string[] options = ["Thunderbolts", "Cosmos"];
string choice = outputHandler.SimpleMenu("Which campaign would you like to play?", options);
switch (choice)
{
    case "Thunderbolts":
        heroPool = heroPoolFactory.ThunderboltHeroPool();
        break;
    case "Cosmos":
        heroPool = heroPoolFactory.CosmosHeroPool();
        break;
}
if (heroPool != null)
{
    List<Hero> startingHeroes = heroPool.GetStartingHeroes();
    Console.WriteLine("Your starting team is:");
    foreach (Hero hero in startingHeroes)
        Console.WriteLine(hero);
}
Console.WriteLine("Press enter to quit!");
Console.ReadLine();
