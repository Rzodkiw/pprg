namespace RogueArena.Core.Characters;

public class Hero
{
    public string Name { get; }
    public int Health { get; private set; }

    public Hero(string name, int health)
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