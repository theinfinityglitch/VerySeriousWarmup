using ArcadianEngine;

namespace VerySeriousWarmup;

public class VerySeriousWarmupGame : IArcadianGame<VerySeriousWarmupGame>
{
    public void OnInitialize(GameContext<VerySeriousWarmupGame> cx)
    {
        Console.WriteLine("Hello, World!");
    }
}
