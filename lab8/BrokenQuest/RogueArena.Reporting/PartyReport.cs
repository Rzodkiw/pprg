using RogueArena.Core.Characters;

namespace RogueArena.Reporting;

public static class PartyReport
{
    public static string Create(Hero hero, Companion companion)
    {
        return $"Drużyna: {hero.Name} i {companion.Name}.";
    }
}