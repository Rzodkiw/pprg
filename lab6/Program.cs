string heroName = "Wiktor";
int health = 70;
int maxHealth = 100;
int gold = 15;
int strength = 6;
int weaponDamage = 3;
bool isRunning = true;

RunShopTests();

while (isRunning)
{
    ShowStatus(heroName, health, maxHealth, gold);
    ShowMenu();
    string command = ReadCommand();

    if (command == "1")
    {
        int damage = CalculateDamage(strength, weaponDamage);
        Console.WriteLine($"Zadajesz {damage} obrażeń manekinowi.");
    }
    else if (command == "2")
    {
        health = Heal(health, 10, maxHealth);
        Console.WriteLine($"Odpoczywasz. Masz teraz {health} HP.");
    }
    else
    {
        isRunning = false;
    }
}

bool CanAfford(int gold, int price) => gold >= price;

int BuyItem(int gold, int price)
{
    if (CanAfford(gold, price))
    {
        return gold - price;
    }
    Console.WriteLine("Za mało złota!");
    return gold;
}

void RunShopTests()
{
    Console.WriteLine("=== TESTY ZAKUPÓW ===");
    int playerGold = 15;

    int r1 = BuyItem(playerGold, 10);
    int r2 = BuyItem(playerGold, 15); 
    int r3 = BuyItem(playerGold, 25);

    Console.WriteLine($"Wyniki testów: [{r1}, {r2}, {r3}] (Oczekiwano: 5, 0, 15)");
    Console.WriteLine("=====================\n");
}

int CalculateDamage(int strength, int weaponDamage) => strength + weaponDamage;

bool IsGameOver(int health) => health <= 0;

string ReadCommand()
{
    while (true)
    {
        Console.Write("Wybór: ");
        string? command = Console.ReadLine();

        if (command == "1" || command == "2" || command == "3")
        {
            return command;
        }

        Console.WriteLine("Nieznana komenda. Wybierz 1, 2 lub 3.");
    }
}

int Heal(int health, int amount, int maxHealth)
{
    int newHealth = health + amount;
    if (newHealth > maxHealth)
    {
        return maxHealth;
    }
    return newHealth;
}

void ShowStatus(string name, int health, int maxHealth, int gold)
{
    Console.WriteLine("====================");
    Console.WriteLine($"Bohater: {name}");
    Console.WriteLine($"Zdrowie: {health}/{maxHealth}");
    Console.WriteLine($"Złoto: {gold}");
    Console.WriteLine("====================");
}

void ShowMenu()
{
    Console.WriteLine("1. Atak treningowy");
    Console.WriteLine("2. Odpoczynek");
    Console.WriteLine("3. Koniec gry");
}