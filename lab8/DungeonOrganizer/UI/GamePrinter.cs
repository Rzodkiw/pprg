namespace DungeonOrganizer.UI;

public static class GamePrinter
{
    public static void ShowHeader(string title)
    {
        Console.WriteLine($"=== {title.ToUpper()} ===");
    }

    public static void ShowCharacter(string name, int health)
    {
        Console.WriteLine($"{name}: {health} HP");
    }

    public static void ShowItem(string name, int price)
    {
        Console.WriteLine($"{name}: {price} szt. złota");
    }
}