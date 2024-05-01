﻿using System;
using NovaDrift.Scripts.Prefabs.Actors;
using NovaDrift.Scripts.Prefabs.Actors.Mobs;
using NovaDrift.Scripts.Prefabs.Components;

namespace NovaDrift.Scripts;

public enum Layer
{
    None = 0,
    Player = 1,
    Mob = 2,
    PlayerHitBox = 3,
    PlayerHurtBox = 4,
    MobHitBox = 5,
    MobHurtBox = 6,
}

public enum GamePlatform
{
    Desktop,
    Mobile,
}

public static class Global
{
    public static GamePlatform CurrentPlatform = GamePlatform.Desktop;
    
    public static Player Player;
    public static GameWorld GameWorld;

    public static Action<MobBase> OnMobDied;
    public static Action<int> OnPlayerUpLevel;
    public static Action OnPlayerDead;
    public static Action OnGameOver;
    public static Action OnGameInit;
    public static Action OnGameStart;

    public static HazardSpawner HazardSpawner;

    private static int _stopCount;

    public static void StopGame()
    {
        _stopCount++;
        GameWorld.GetTree().Paused = _stopCount > 0;
    }

    public static void ResumeGame()
    {
        _stopCount--;
        GameWorld.GetTree().Paused = _stopCount > 0;
    }

    public static int GetPlayerLevel()
    {
        if (Player == null) return 1;
        return Player.Stats.Level;
    }
}