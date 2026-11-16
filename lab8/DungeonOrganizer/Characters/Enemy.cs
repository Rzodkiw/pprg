namespace DungeonOrganizer.Characters;

public class Enemy
{
    public string Name { get; }
    public int Health { get; private set; }

    public Enemy(string name, int health)
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