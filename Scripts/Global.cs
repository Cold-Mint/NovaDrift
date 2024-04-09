﻿using NovaDrift.Scripts.Prefabs.Actors;

namespace NovaDrift.Scripts;

public enum Layer
{
    Player = 1,
    Mob = 2,
    PlayerHitBox = 3,
    PlayerHurtBox = 4,
    MobHitBox = 5,
    MobHurtBox = 6,
}

public class Global
{
    public static Player Player;
    public static GameWorld GameWorld;
}