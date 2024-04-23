﻿using Godot;
using NovaDrift.addons.AcidStats;

namespace NovaDrift.Scripts.Systems.Effects;

public class SiegeWeaponry : Effect
{
    private StatModifier _shootSpeedModifier;
    
    public override void OnCreate()
    {
        base.OnCreate();

        _shootSpeedModifier = new StatModifier(Values[0], StatModType.PercentAdd);
        
        Target.StartShooting += () =>
        {
            AddModifierToTarget(_shootSpeedModifier, Target.Stats.ShootSpeed);
            AddModifierToTarget(new StatModifier(
                Values[1], StatModType.PercentAdd), Target.Stats.ShootKnockBack);
        };
        
        Target.OnShooting += () =>
        {
            if (_shootSpeedModifier.Value >= 1f) return;

            _shootSpeedModifier.Value += Values[0];
            Target.Stats.ShootSpeed.ForceCalculate();
            GD.Print(Target.Stats.ShootSpeed.Value);
        };

        Target.StopShooting += RemoveAllModifierFromTarget;
    }

}