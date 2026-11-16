using DungeonOrganizer.Characters;
using DungeonOrganizer.Items;
using DungeonOrganizer.World;
using InventoryItem = DungeonOrganizer.Items.Item;
using MapItem = DungeonOrganizer.World.Item;
using DungeonOrganizer.UI;

Player player = new Player("Wiktor", 100);
Enemy enemy = new Enemy("Goblin", 30);

InventoryItem item = new InventoryItem("Mikstura", 15);
MapItem mapItem = new MapItem("!");

GamePrinter.ShowHeader("Dungeon Organizer");
GamePrinter.ShowCharacter(player.Name, player.Health);
GamePrinter.ShowCharacter(enemy.Name, enemy.Health);

Console.WriteLine($"Przedmiot: {item.Name}, cena: {item.Price}");
Console.WriteLine($"Symbol na mapie: {mapItem.Symbol}");