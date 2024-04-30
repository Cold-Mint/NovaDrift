using NovaDrift.Scripts.Prefabs.Components;

namespace NovaDrift.Scripts;

public sealed class PlayerCommands
{
    public int SomethingId { get; set; }
    public void UseAbilityById() => DataBuilder.BuildAbilityById(SomethingId).Use();
    public void UseShooterById() => DataBuilder.BuildWeaponById(SomethingId).Use();

    public void RemoveAllEffects() => Global.Player.Stats.EffectSystem.RemoveAllEffects();
}

public sealed class WorldCommands
{
    public int SomethingId { get; set; }
    public void GenerateMobById() => MobSpawner.GenerateMobByIdAction?.Invoke(SomethingId);
}
