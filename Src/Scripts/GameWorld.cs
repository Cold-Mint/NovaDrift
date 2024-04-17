using AcidJoystick;
using DsUi;
using Godot;
using NovaDrift.Scripts.Prefabs.Actors;

namespace NovaDrift.Scripts;

public partial class GameWorld : Node2D
{
    private Joystick _moveJoystick;
    private Joystick _aimJoystick;
    
    public override void _Ready()
    {
        Global.OnGameInit += Init;
        Global.OnGameOver += GameOver;
        Global.OnGameStart?.Invoke();
        
        DataBuilder.Init();
        Init();
    }

    private void Init()
    {
        _moveJoystick = GetNode<Joystick>("%MoveJoystick");
        _aimJoystick = GetNode<Joystick>("%AimJoystick");
        
        _moveJoystick.Visible = Global.CurrentPlatform != GamePlatform.Desktop;
        _aimJoystick.Visible = Global.CurrentPlatform != GamePlatform.Desktop;

        UiManager.Open_Hud();
        
        Global.GameWorld = this;
        
        Player player = GD.Load<PackedScene>("res://Scenes/Prefabs/Actors/Player.tscn").Instantiate<Player>();
        player.JoystickNode = _moveJoystick;
        AddChild(player);
        
        DataBuilder.BuildBodyById(1000).Use();
        DataBuilder.BuildWeaponById(1000).Use();

        UiManager.Get_Hud_Instance()[0].OpenNestedUi(UiManager.UiName.StatsMonitor);
    }

    private async void GameOver()
    {
        GetTree().CallGroup("Mobs", Node.MethodName.QueueFree);
        
        Global.Player.CallDeferred(Node.MethodName.QueueFree);
        UiManager.Open_GameOver();
    }
}
