using Godot;
using NovaDrift.Scripts.Prefabs.Actors;
using NovaDrift.Scripts.Systems;

namespace NovaDrift.Scripts.Prefabs.Bullets;

public partial class Grenade : BulletBase
{
    private float _deceleration = 100f;
    private float _acceleration = 300f;
    private Vector2 _maxVelocity = new Vector2(300f, 300f);

    private Timer _timer;

    public override void _Ready()
    {
        base._Ready();
        _timer = new Timer()
        {
            WaitTime = 3f,
            OneShot = true
        };
        
        AddChild(_timer);
        _timer.Start();
        
        _timer.Timeout += Blast;
    }
    
    protected override void Degenerate() { }

    protected override void OnHitHandle(Actor actor)
    {
        TakeOnHitEvent(actor);
        Blast();
    }

    protected override void OnHitOthersHandle()
    {
        Blast();
    }

    private void Blast()
    {
        var fireBall = 
            new BulletBuilder(BulletBuilder.BulletType.FireBall).
                SetDamage(Damage).
                SetOwner(Target).
                SetBlastRadius(Target.Stats.BlastRadius.Value).
                Build();
        fireBall.GlobalPosition = GlobalPosition;
        Global.GameWorld.CallDeferred(Node.MethodName.AddChild, fireBall);
        QueueFree();
    }

    protected override void Move(double delta)
    {
        OnMove?.Invoke(GlobalPosition.DistanceTo(LastPosition));

        if (Velocity.Length() >= _maxVelocity.Length())
        {
            Velocity = Velocity.MoveToward(Vector2.Zero, _deceleration);
        }
        else
        {
            Velocity.MoveToward(_maxVelocity, _acceleration);
        }

        Position += Velocity * (float)delta;
        LastPosition = GlobalPosition;
    }
    
}
