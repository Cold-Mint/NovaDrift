﻿using Godot;
using NovaDrift.Scripts.Systems;

namespace NovaDrift.Scripts.Prefabs.Components;

[GlobalClass]
public partial class Shooter : Node2D
{
    private Timer _shootTimer;
    private float _shootCd = 0.1f;

    public override void _Ready()
    {
        _shootTimer = new Timer();
        AddChild(_shootTimer);
        _shootTimer.OneShot = true;
        _shootTimer.WaitTime = _shootCd;
    }

    public virtual void Shoot(Vector2 targetDir)
    {
        if (!_shootTimer.IsStopped())
        {
            return;
        }
        BulletBase bullet = new BulletBuilder().SetTargetDir(targetDir).Build();
        Global.GameWorld.AddChild(bullet);
        bullet.GlobalPosition = GlobalPosition;
        _shootTimer.Start();
    }
}