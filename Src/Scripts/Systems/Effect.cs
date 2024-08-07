﻿using System;
using System.Collections.Generic;
using NovaDrift.addons.AcidStats;
using NovaDrift.Scripts.Prefabs.Actors;

namespace NovaDrift.Scripts.Systems;

public class Effect
{
    public string Name;
    // 目标
    public Actor Target;
    // 冷却时间
    public float Cooldown = 0f;
    // 是否无限时间
    public bool Infinite = false;
    // 是否自动开启
    public bool AutoStart = false;
    public bool IsMutationAbility = false;
    
    public Action<Effect> OnDestroyed;

    private readonly List<(Stat, StatModifier)> _statModifiers = new List<(Stat, StatModifier)>();

    public List<float> Values = new List<float>();

    protected void AddModifierToTarget(StatModifier modifier, Stat target)
    {
        if (Target == null) return;
        target.AddModifier(modifier);
        _statModifiers.Add((target, modifier));
    }
    
    public virtual void OnCreate()
    {
    }

    public virtual void Update()
    {
    }

    public virtual void Process()
    {
    }

    protected void RemoveAllModifierFromTarget()
    {
        foreach (var value in _statModifiers)
        {
            value.Item1.RemoveAllModifiersFromSource(value.Item2);
        }
    }

    public virtual void OnDestroy()
    {
        RemoveAllModifierFromTarget();
        OnDestroyed?.Invoke(this);
    }
}