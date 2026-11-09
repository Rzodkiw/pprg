public class Player
{
    public string Name { get; }
    public int Health { get; private set; }
    public int MaxHealth { get; private set; }
    public int Gold { get; set; }
    public int Level { get; private set; }
    public int Experience { get; private set; }
    public int ExperienceToNextLevel { get; private set; }
    public List<Item> Inventory { get; }
    public bool IsDefending { get; private set; }

    public Player(string name, int maxHealth, int gold)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Gold = gold;
        Level = 1;
        Experience = 0;
        ExperienceToNextLevel = 50;
        Inventory = new List<Item>();
        IsDefending = false;
    }

    public bool TakeDamage(int damage)
    {
        if (!IsAlive()) return false;
        if (damage < 0) return false;

        int finalDamage = damage;
        if (IsDefending)
        {
            finalDamage = Math.Max(1, damage / 2);
            Console.WriteLine($"[Gracz: {Name}] Przyjął postawę obronną! Obrażenia zredukowane do {finalDamage}.");
            IsDefending = false;
        }

        Health = Math.Max(0, Health - finalDamage);
        return true;
    }

    public void SetDefending(bool defending)
    {
        IsDefending = defending;
    }

    public bool Heal(int amount)
    {
        if (!IsAlive() || amount <= 0 || Health >= MaxHealth) return false;
        Health = Math.Min(MaxHealth, Health + amount);
        return true;
    }

    public bool IsAlive() => Health > 0;

    public void GainExperience(int amount)
    {
        if (amount <= 0) return;
        Experience += amount;
        Console.WriteLine($"[GRACZ] Zyskano {amount} punktów doświadczenia ({Experience}/{ExperienceToNextLevel} XP).");

        while (Experience >= ExperienceToNextLevel)
        {
            Experience -= ExperienceToNextLevel;
            LevelUp();
        }
    }

    private void LevelUp()
    {
        Level++;
        MaxHealth += 20;
        Health = MaxHealth;
        ExperienceToNextLevel = (int)(ExperienceToNextLevel * 1.5f);
        Console.WriteLine($"\n*** AWANS! {Name} awansował na {Level} poziom! ***");
        Console.WriteLine($"Max zdrowie zwiększone do {MaxHealth} HP (pełne odnowienie zdrowia)!\n");
    }

    public void AddItem(Item item)
    {
        Item existing = Inventory.Find(i => i.Name == item.Name);
        if (existing != null)
        {
            existing.AddQuantity(item.Quantity);
        }
        else
        {
            Inventory.Add(item);
        }
    }

    public void ShowInventory()
    {
        Console.WriteLine($"=== EKWIPUNEK: {Name} ===");
        if (Inventory.Count == 0)
        {
            Console.WriteLine("Ekwipunek jest pusty.");
            return;
        }

        for (int i = 0; i < Inventory.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Inventory[i].Name} | Leczenie: {Inventory[i].HealAmount} HP | Sztuk: {Inventory[i].Quantity}");
        }
    }

    public void UseItem(int index)
    {
        if (index < 0 || index >= Inventory.Count)
        {
            Console.WriteLine("Błąd: Nie ma takiego przedmiotu w ekwipunku.");
            return;
        }

        Item item = Inventory[index];
        if (item.Quantity <= 0)
        {
            Console.WriteLine($"Błąd: Przedmiot {item.Name} się skończył!");
            return;
        }

        if (Health == MaxHealth)
        {
            Console.WriteLine("Masz już maksymalne zdrowie!");
            return;
        }

        if (item.UseOne())
        {
            Heal(item.HealAmount);
            Console.WriteLine($"Użyto {item.Name}! Odzyskano punkty zdrowia.");
        }
    }
}