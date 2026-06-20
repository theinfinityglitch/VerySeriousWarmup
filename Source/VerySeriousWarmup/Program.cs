using ArcadianEngine;

namespace VerySeriousWarmup;

internal static class Program
{
    private static void Main()
    {
        Game<VerySeriousWarmupGame> game = new(new(), "Very Serious Warmup Game", new(1280, 720));
        game.Run();
    }
}
