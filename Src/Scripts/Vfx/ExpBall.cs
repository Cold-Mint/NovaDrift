using System;
using AcidWallStudio.AcidUtilities;
using Godot;

namespace NovaDrift.Scripts.Vfx;

public partial class ExpBall : Node2D
{
    [GetNode("Area2D")] private Area2D _area;
    public Vector2 Pos;
    
    public override void _Ready()
    {
        AddToGroup("ExpBalls");
        GlobalPosition = Pos + new Vector2(
            Random.Shared.FloatRange(-100f, 100f),
            Random.Shared.FloatRange(-100f, 100f));
        //FIXME: throw a error, but why?
        EventBus.OnGameOver += QueueFree;
    }

    public void Get()
    {
        Global.Player.Stats.Exp.Increase(1);
        QueueFree();
    }
}
