﻿using System;
using AcidWallStudio.Fmod;
using DwarfImpulse;
using Godot;
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
    Object = 7,
    PlayerBullet = 8,
    MobBullet = 9,
}

public enum GamePlatform
{
    Desktop,
    Mobile,
}

public enum InputDevice
{
    Keyboard,
    Joystick,
    VirtualJoystick,
}

public class GameContext
{
    public int Score;

    public GameContext()
    {
        EventBus.OnMobDied += @base =>
        {
            var info = @base.MobInfo;
            AddScore((int)(info.DangerFactor * info.Health));
        };
    }

    public void AddScore(int amount)
    {
        Score += amount;
    }
}

public static class Global
{
    public static event Action OnAcidCoinsChanged;
    
    public static GamePlatform CurrentPlatform = GamePlatform.Desktop;
    public static InputDevice CurrentInputDevice = InputDevice.Keyboard;
    
    public static Player Player;
    public static Node2D PlayerStand;
    public static Node2D Something;
    public static GameWorld GameWorld;
    public static ShakeDirector2D ShakeDirector;
    public static FastNoiseLite Noise;
    public static WaveSpawnerController WaveSpawnerController;
    public static GameContext GameContext = new GameContext();

    public static int AcidCoins
    {
        get => _acidCoins;
        set
        {
            _acidCoins = value;
            OnAcidCoinsChanged?.Invoke();
        }
    }

    private static int _acidCoins;

    public static Constants.WorldColor WorldColor = Constants.Colors.Blue;
    
    public static HazardSpawner HazardSpawner;

    private static int _stopCount;

    public static SceneTree SceneTree
    {
        get => _sceneTree;
        set
        {
            _sceneTree = value;
            _sceneTree.NodeAdded += node =>
            {
                switch (node)
                {
                    case BaseButton button:
                        ConnectButtonSoundsSignal(button);
                        break;
                    case MobBase mobBase:
                        EventBus.EnteredMob(mobBase);
                        break;
                    default:
                        break;
                }
            };
        }
    }

    private static SceneTree _sceneTree;

    private static void ConnectButtonSoundsSignal(BaseButton button)
    {
        button.Pressed += () =>
        {
            SoundManager.PlayOneShotById("event:/ButtonClicked");
        };
    }

    public static void Shake(float strength)
    {
        Global.ShakeDirector.Shake(
            NoiseShake.CreateWithNoise(Global.Noise)
                .WithDuration(0.5f)
                .WithEulersAmount(new Vector3(strength, strength, 0.02f))
        );
    }

    public static void SetWorldColor(Constants.WorldColor color)
    {
        WorldColor = color;
        EventBus.OnWorldColorChanged();
    }

    public static void StopGame()
    {
        _stopCount++;
        GameWorld.GetTree().Paused = _stopCount > 0;
        Logger.Log($"[Global] Try Stop game. Stop count: {_stopCount}");
    }

    public static void ResumeGame()
    {
        _stopCount--;
        GameWorld.GetTree().Paused = _stopCount > 0;
        Logger.Log($"[Global] Try Resume game. Stop count: {_stopCount}");
    }

    public static int GetPlayerLevel()
    {
        if (Player == null) return 1;
        return Player.Stats.Level;
    }
}