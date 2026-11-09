public class Item
{
    public string Name { get; }
    public int HealAmount { get; }
    public int Quantity { get; private set; }

    public Item(string name, int healAmount, int quantity)
    {
        Name = name;
        HealAmount = healAmount;
        Quantity = quantity;
    }

    public void AddQuantity(int amount)
    {
        if (amount > 0)
        {
            Quantity += amount;
        }
    }

    public bool UseOne()
    {
        if (Quantity <= 0)
        {
            return false;
        }

        Quantity--;
        return true;
    }
}