namespace RogueArena.Core.Characters;

public class Monster
{
    public string Name { get; }
    public int Health { get; private set; }

    public Monster(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
    }
}
