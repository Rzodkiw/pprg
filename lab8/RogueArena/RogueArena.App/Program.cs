Hero hero = new Hero("Wiktor", 100);
Monster monster = new Monster("Ork", 45);

int damage = CombatRules.CalculateDamage(7, 5);
monster.TakeDamage(damage);

ArenaPrinter.ShowTitle("Rogue Arena");
Console.WriteLine($"{hero.Name} zadaje {damage} obrażeń.");
ArenaPrinter.ShowHealth(monster.Name, monster.Health);

Console.WriteLine();
Inventory inventory = new Inventory();
inventory.Add(new Item("Miecz", 40));
inventory.Add(new Item("Mikstura", 15));

Console.WriteLine("--- Ekwipunek ---");
foreach (Item item in inventory.Items)
{
    Console.WriteLine($"- {item.Name}: {item.Price} zł");
}

Console.WriteLine($"Łączna wartość: {inventory.CalculateValue()}");