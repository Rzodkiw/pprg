namespace RogueArena.Core.Combat;

public static class CombatRules
{
    public static int CalculateDamage(int strength, int weaponDamage)
    {
        return strength + weaponDamage;
    }
}
