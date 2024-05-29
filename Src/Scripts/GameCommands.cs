using NovaDrift.Scripts.Prefabs.Components;

namespace NovaDrift.Scripts;

public sealed class PlayerCommands
{
    public int SomethingId { get; set; } = 1001;
    public void UseAbilityById() => DataBuilder.BuildAbilityById(SomethingId).Use();
    public void UseShooterById() => DataBuilder.BuildWeaponById(SomethingId).Use();
    public void UseBodyById() => DataBuilder.BuildBodyById(SomethingId).Use();
    public void UseShieldById() => DataBuilder.BuildShieldById(SomethingId).Use();
    public void LevelUp() => Global.Player.UpLevel();

    public void RemoveAllEffects() => Global.Player.Stats.EffectSystem.RemoveAllEffects();
}

public sealed class WorldCommands
{
    public int SomethingId { get; set; } = 1001;
    public void GenerateMobById() => MobSpawner.GenerateMobByIdAction?.Invoke(SomethingId);
    public void GenerateBossById() => MobSpawner.GenerateBossById?.Invoke(SomethingId);
    
    public HazardSpawner.HazardType HazardType { get; set; }
    public void SpawnHazard() => Global.HazardSpawner.SpawnHazard(HazardType);
    
    public enum WorldColors
    {
        Red,
        Blue,
    }
}
