using ArcadianEngine;
using ArcadianEngine.Math;

namespace VerySeriousWarmup;

internal static class Program
{
    private static void Main()
    {
        Game<VerySeriousWarmupGame> game = new(
            new VerySeriousWarmupGame(),
            "Very Serious Warmup",
            new Vector2I(1280, 720)
        );
        game.Run();
    }
}
