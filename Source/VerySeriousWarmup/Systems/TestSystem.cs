using ArcadianEngine;
using ArcadianEngine.Resources;
using Friflo.Engine.ECS.Systems;
using Microsoft.Xna.Framework;
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
                rp.DrawRect(new Rectangle(20, 20, 100, 50), Color.Blue);
            }
        );
    }
}
