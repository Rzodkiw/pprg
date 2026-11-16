namespace DungeonOrganizer.Characters;

public class Player
{
    public string Name { get; }
    public int Health { get; private set; }

    public Player(string name, int health)
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