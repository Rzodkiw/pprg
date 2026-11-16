using RogueArena.Core.Characters;
using RogueArena.Core.Rewards;
using RogueArena.Reporting;

Hero hero = new Hero("Wiktor", 100);
Monster monster = new Monster("Ork", 45);
Companion companion = new Companion("Borys");

int reward = RewardCalculator.Calculate(monster.Health);

string battleText = BattleReport.Create(hero, monster, reward);
string partyText = PartyReport.Create(hero, companion);

Console.WriteLine(battleText);
Console.WriteLine(partyText);