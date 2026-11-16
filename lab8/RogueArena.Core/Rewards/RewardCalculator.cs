namespace RogueArena.Core.Rewards;

public static class RewardCalculator
{
    public static int Calculate(int monsterHealth)
    {
        return monsterHealth / 3;
    }
}
