using ArcadianEngine;
using Friflo.Engine.ECS;
using Microsoft.Xna.Framework;
using VerySeriousWarmup.Components;
using VerySeriousWarmup.Systems;

namespace VerySeriousWarmup;

public class VerySeriousWarmupGame : ArcadianGame<VerySeriousWarmupGame>
{
    public override void OnInitialize()
    {
        Context.Game.Window.AllowUserResizing = true;
        Context.InsertSystem<Update, TestSystem>(new TestSystem(Context));
        Context.Game.World.CreateEntity(new TestComponent());
    }

    public override void OnUpdate(GameTime time)
    {
        base.OnUpdate(time);
    }

    public override void OnDraw()
    {
        base.OnDraw();
    }
}
