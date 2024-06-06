﻿using System;
using System.Linq;
using AcidWallStudio.AcidUtilities;
using AcidWallStudio.Fmod;
using DsUi;
using Godot;
using NovaDrift.Scripts.Ui.BuffIcon;

namespace NovaDrift.Scripts.Systems.Buffs;

public class Madness : Buff
{
    private int _strength = 1; // 实际上是层级

    private Timer _voiceTimer;
    private Timer _scareTimer;
    
    public override void OnCreate()
    {
        _voiceTimer = new Timer
        {
            WaitTime = 0.5f,
            OneShot = true,
        };
        Global.GameWorld.AddChild(_voiceTimer);
        _voiceTimer.Timeout += PlayVoice;
        ShowToUi();
        PlayVoice();
    }

    public void LevelUp()
    {
        _strength = Mathf.Min(_strength + 1, 3);
        Logger.Log("[Buff] Madness level up. Strength: " + _strength);
        ShowToUi();
        
        if (_strength == 2)
        {
            if (_scareTimer != null) _scareTimer.QueueFree();
            _scareTimer = new Timer()
            {
                WaitTime = 0.5f,
                OneShot = true,
            };
            _scareTimer.Timeout += JumpScare;
            Global.GameWorld.AddChild(_scareTimer);
            _scareTimer.Start();
            return;
        }
        
    }
    
    public void LevelDown()
    {
        _strength = Mathf.Max(_strength - 1, 0);
        Logger.Log("[Buff] Madness level down. Strength: " + _strength);
        
        if (_strength == 0)
        {
            Destroy();
            return;
        }

        if (_strength < 2)
        {
            if (_scareTimer != null) _scareTimer.QueueFree();
        }

        ShowToUi();
    }

    protected override void Destroy()
    {
        base.Destroy();
        _voiceTimer.QueueFree();
        if (_scareTimer != null) _scareTimer.QueueFree();
    }

    private void PlayVoice()
    {
        SoundManager.PlayOneShotById("event:/Mobs/Bosses/TheDoctor/Voice");
        _voiceTimer.WaitTime = Random.Shared.FloatRange(6f, 12f);
        _voiceTimer.Start();
    }

    private void JumpScare()
    {
        // SoundManager.PlayOneShotById("event:/Mobs/Bosses/TheDoctor/JumpScare");
        Node2D scare = GD.Load<PackedScene>("res://Scenes/Vfx/DoctorScare.tscn").Instantiate() as Node2D;
        if (scare == null) return;
        Global.GameWorld.AddChild(scare);
        _scareTimer.WaitTime = Random.Shared.FloatRange(2f, 4f);
        _scareTimer.Start();
    }

    protected override void ShowToUi()
    {
        var hud = UiManager.Get_Hud_Instance().First();
        if (hud == null) return;
        
        BuffIconPanel getBuff = hud.GetBuffIcon(this);
        
        if (getBuff == null)
        {
            hud.AddBuffIcon(this, GetRatio());
            return;
        }
        
        // --- Animation ---
        var animationPanel = UiManager.Create_BuffIcon();
        animationPanel.UpdateUi(this);
        animationPanel.ShowUi();
        animationPanel.UpdateUiWithAnimation(this, GetRatio(), GetRatioByLevel(Mathf.Min(_strength - 1, 1)));
        // ----------------
        
        getBuff.UpdateProgressBar(GetRatio());
    }

    public override float GetRatio()
    {
        return GetRatioByLevel(_strength);
    }
    
    private float GetRatioByLevel(int level)
    {
        return level switch
        {
            1 => 33f,
            2 => 66f,
            3 => 100f,
            _ => 0f
        };
    }
}