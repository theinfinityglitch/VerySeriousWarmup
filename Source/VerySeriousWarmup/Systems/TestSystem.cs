using ArcadianEngine;
using ArcadianEngine.Resources;
using Friflo.Engine.ECS.Systems;
using Raylib_cs;
using VerySeriousWarmup.Components;

namespace VerySeriousWarmup.Systems;

public class TestSystem(GameContext<VerySeriousWarmupGame> Context) : QuerySystem<TestComponent>
{
    protected GameContext<VerySeriousWarmupGame> Context = Context;

    protected override void OnUpdate()
    {
        var rp = Context.GetResource<RenderPipeline<VerySeriousWarmupGame>>();

        Query.ForEachEntity(
            (ref tc, entity) =>
            {
                Console.WriteLine(tc.SomeRandomData);
                rp.DrawRect(new(10, 50, 50, 10), Color.Blue);
            }
        );
    }
}
