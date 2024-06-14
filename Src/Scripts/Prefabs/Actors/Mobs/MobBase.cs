using System;
using Godot;
using NovaDrift.Scripts.Systems;
using NovaDrift.Scripts.Systems.Formations;
using NovaDrift.Scripts.Vfx;

namespace NovaDrift.Scripts.Prefabs.Actors.Mobs;

public partial class MobBase : Actor
{
    public MobInfo MobInfo;
    public bool IsBoss = false;
    public MobAiComponent Ai;
    public Formation Formation;

    private Node2D _target;
    
    [Export] public string Sign;

    // private void AddNodeToSpring(Node node)
    // {
    //     if (node is not Node2D node2D) return;
    //     Spring.AddTargetPoint(new SpringInfo(SpringType.Push, node2D, 1000f));
    // }

    public override void _Ready()
    {
        Stats.Recoil.BaseValue = 0f;
        if (MobInfo == null) throw new Exception("MobInfo 为 Null");

        Ai = GetNode<MobAiComponent>("%MobAiComponent");
        
        // EventBus.OnMobEnteredTree += (node) =>
        // {
        //     if (IsBoss) return;
        //     AddNodeToSpring(node);
        // };
        
        base._Ready();
        AddToGroup("Mobs");
        
        // if (!IsBoss) Spring.AddTargetPoint(new SpringInfo(SpringType.Pull, Global.Player, 1f));
        
        // foreach (var mob in GetTree().GetNodesInGroup("Mobs"))
        // {
        //     if (IsBoss) break;
        //     AddNodeToSpring(mob);
        // }

        // EventBus.OnMobDied += Spring.RemoveTargetPoint;

        Stats.Health.ValueChanged += (value) =>
        {
            if (value <= 0)
            {
                Die();
            }
        };
        
        // if (Shooter != null) Shooter.Init();
        // Set position by formation.
        GlobalPosition = ToGlobal(Formation.GetPoint(this));
    }
    
    protected override void InitStats()
    {
        Stats.Level = Mathf.Max(Global.GetPlayerLevel() - 1, 1);
        Stats.RotationSpeed.BaseValue = 2f;

        Stats.Size.BaseValue = MobInfo.Size;
        
        Stats.Health.BaseValue = MobInfo.Health * Stats.Level;
        Stats.Health.MaxValue.BaseValue = MobInfo.Health * Stats.Level;
        
        Stats.Speed.BaseValue = MobInfo.Speed;
        Stats.Damage.BaseValue = MobInfo.Damage * Stats.Level;
        Stats.ShootSpeed.BaseValue = MobInfo.ShootCd;

        Stats.Targeting.BaseValue = MobInfo.Targeting;

        Stats.BulletCount.BaseValue = MobInfo.BulletCount;
        
        Shooter.SetShootCd(MobInfo.ShootCd);
    }

    public override void Die()
    {
        if (IsDead) return;

        var temp = new Vector2(10f, 10f);
        for (int i = 0; i < MobInfo.GetExp; i++)
        {
            var expBall = GD.Load<PackedScene>("res://Scenes/Vfx/ExpBall.tscn").Instantiate<ExpBall>();
            expBall.Pos = GlobalPosition + temp * i;
            Global.GameWorld.AddChild(expBall);
        }
        
        EventBus.OnMobDied?.Invoke(this);
        base.Die();
    }

    public void RemoveSelf()
    {
        base.Die();
    }

    public float GetDistanceToPlayer()
    {
        return Global.Player.GlobalPosition.DistanceTo(GlobalPosition);
    }

    public void SetTargetAndMove(Node2D target, float delta)
    {
        Rotation = RotationTo(GlobalPosition.AngleToPoint(target.GlobalPosition), delta);

        // if (this == Formation.Leader)
        // {
        //     Formation.Move(GlobalPosition.DirectionTo(target.GlobalPosition), delta);
        //     return;
        // }
        // return;

        TryMoveTo(GlobalPosition.DirectionTo(target.GlobalPosition), delta);
    }

    public override void TryMoveTo(Vector2 dir, double delta)
    {
        Rotation = RotationTo(GlobalPosition.AngleToPoint(dir), delta);

        // if (this == Formation.Leader)
        // {
        //     Formation.Move(dir, (float)delta);
        //     return;
        // }
        // return;
        
        var targetVelocity = dir * Stats.Speed.Value;
        Velocity = Velocity.MoveToward(targetVelocity, Stats.Acceleration.Value * (float)delta);
    }

    public void LookForward(float delta)
    {
        Rotation = RotationTo(Velocity.Angle(), delta);
    }
    
    public void LookAtPlayer(float delta)
    {
        Rotation = RotationTo(GlobalPosition.AngleToPoint(Global.Player.GlobalPosition), delta);
    }
    
    public void LookBack(float delta)
    {
        Rotation = RotationTo(Velocity.Angle() + MathF.PI, delta);
    }
}
