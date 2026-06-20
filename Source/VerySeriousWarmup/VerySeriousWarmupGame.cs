using ArcadianEngine;
using ArcadianEngine.Resources;
using Friflo.Engine.ECS;
using Raylib_cs;
using VerySeriousWarmup.Components;
using VerySeriousWarmup.Systems;

namespace VerySeriousWarmup;

public class VerySeriousWarmupGame : ArcadianGame<VerySeriousWarmupGame>
{
    protected RenderPipeline<VerySeriousWarmupGame> RenderPipeline = null!;

    public override void OnInitialize()
    {
        RenderPipeline = Context.GetResource<RenderPipeline<VerySeriousWarmupGame>>();

        Context.InsertSystem<Update, TestSystem>(new TestSystem(Context));
        Context.Game.World.CreateEntity(new TestComponent());
    }

    public override void OnUpdate(float deltaTime)
    {
        base.OnUpdate(deltaTime);
    }

    public override void OnDraw()
    {
        RenderPipeline.Clear(Color.Black);

        base.OnDraw();
    }
}
