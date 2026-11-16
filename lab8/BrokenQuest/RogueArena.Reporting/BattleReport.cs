using RogueArena.Core.Characters;

namespace RogueArena.Reporting;

public static class BattleReport
{
    public static string Create(Hero hero, Monster monster, int reward)
    {
        return $"{hero.Name} pokonał: {monster.Name}; nagroda: {reward}.";
    }
}
