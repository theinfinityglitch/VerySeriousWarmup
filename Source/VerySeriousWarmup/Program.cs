using ArcadianEngine;
using ArcadianEngine.Math;

namespace VerySeriousWarmup;

internal static class Program
{
    private static void Main()
    {
        Game<VerySeriousWarmupGame> game = new(new VerySeriousWarmupGame());
        game.Run();
    }
}
