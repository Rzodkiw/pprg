public class Enemy
{
    public string Name { get; }
    public int Health { get; private set; }
    public int MaxHealth { get; }
    public int Damage { get; }
    public string AttackType { get; }
    public int DefenseChance { get; }
    public int GoldReward { get; }
    public bool IsDefending { get; private set; }

    public Enemy(string name, int maxHealth, int damage, string attackType, int defenseChance, int goldReward)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Damage = damage;
        AttackType = attackType;
        DefenseChance = defenseChance;
        GoldReward = goldReward;
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
            Console.WriteLine($"[Przeciwnik: {Name}] Zablokował część ciosu! Obrażenia zredukowane do {finalDamage}.");
            IsDefending = false;
        }

        Health = Math.Max(0, Health - finalDamage);
        return true;
    }

    public void SetDefending(bool defending)
    {
        IsDefending = defending;
    }

    public bool IsAlive() => Health > 0;

    public void AttackTarget(Player target, Random rng)
    {
        if (!IsAlive()) return;
        target.TakeDamage(Damage);
    }
}