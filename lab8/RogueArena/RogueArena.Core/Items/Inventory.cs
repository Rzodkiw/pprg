namespace RogueArena.Core.Items;

public class Inventory
{
    public List<Item> Items { get; } = new List<Item>();

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public int CalculateValue()
    {
        int total = 0;

        foreach (Item item in Items)
        {
            total += item.Price;
        }

        return total;
    }
}
