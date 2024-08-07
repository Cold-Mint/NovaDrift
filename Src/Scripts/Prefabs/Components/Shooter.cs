﻿using AcidWallStudio.AcidUtilities;
using Godot;
using NovaDrift.Scripts.Prefabs.Actors;
using NovaDrift.Scripts.Prefabs.Weapons;

namespace NovaDrift.Scripts.Prefabs.Components;

[GlobalClass]
public partial class Shooter : BaseShooter
{
    private Timer _shootTimer;
    
    private Timer _burstIntervalTimer;
    private Timer _burstCooldownTimer;
    private bool _isBursting;
    
    public override void _EnterTree()
    {
        if (Owner is Actor actor)
        {
            Actor = actor;
        }
    }

    public override void _Ready()
    {
        GetBulletFunc = (shooter) => shooter.GetBullet();
        Init();
    }

    public override void Destroy()
    {
        Actor.Stats.ShootSpeed.ValueChanged -= SetShootCd;
    }

    public override void SetShootCd(float value)
    {
        _shootTimer.Stop();
        _shootTimer.WaitTime = value;
    }
    
    public override void Init()
    {
        if (Owner is Actor actor)
        {
            IsPlayer = actor.IsPlayer;
        }

        _burstCooldownTimer = Wizard.CreateTimer(0.5f);
        AddChild(_burstCooldownTimer);
        _burstCooldownTimer.Timeout += () => _isBursting = false; 
        
        _shootTimer = new Timer();
        AddChild(_shootTimer);
        _shootTimer.OneShot = true;
        _shootTimer.WaitTime = Actor.Stats.ShootSpeed.Value;

        _burstIntervalTimer = new Timer();
        AddChild(_burstIntervalTimer);
        _burstIntervalTimer.OneShot = true;
        _burstIntervalTimer.WaitTime = DataBuilder.Constants.BurstInterval;
        
        Actor.Stats.ShootSpeed.ValueChanged += SetShootCd;
    }

    public override void Shoot()
    {
        if (!_shootTimer.IsStopped()) { return; }
        if (_isBursting) { return; }

        _isBursting = true;
        
        for (int x = 0; x < Actor.Stats.BurstFire.Value; x++)
        {
            for (int i = 0; i < Actor.Stats.BulletCount.Value; i++)
            {
                BulletBase bullet = GetBulletFunc.Invoke(this);
                
                bullet.GlobalPosition = GlobalPosition;
                if ((int)Actor.Stats.BulletCount.Value == 1)
                {
                    bullet.Direction = bullet.Direction.Rotated(GlobalRotation);
                }
                else
                {
                    float arcRad = Mathf.DegToRad(Actor.Stats.ShootSpread.Value);
                    float increment = arcRad / (Actor.Stats.BulletCount.Value - 1);
                    bullet.Direction = bullet.Direction.Rotated(Actor.GlobalRotation + increment * i - arcRad / 2);
                }

                Global.GameWorld.AddChild(bullet);
                
                _shootTimer.Start();
        
                OnShoot?.Invoke(bullet);
                bullet.OnHit += actor => { OnHit?.Invoke(actor); };
                _burstIntervalTimer.Start();
            }
        }

        _burstCooldownTimer.WaitTime = Actor.Stats.ShootSpeed.Value * Actor.Stats.BurstFire.Value;
        _burstCooldownTimer.Start();
    }
}