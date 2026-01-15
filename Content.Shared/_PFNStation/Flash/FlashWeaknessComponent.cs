using Robust.Shared.Serialization;

namespace Content.Shared._PFNStation.Flash;

/// <summary>
/// This is used for...
/// </summary>
[RegisterComponent]
public abstract partial class FlashWeaknessComponent : Component
{
    [DataField]
    public float FlashWeaknessMultiplier = 1f;
}

[Serializable, NetSerializable]
public sealed class FlashWeaknessComponentState : IComponentState
{
    public float FlashWeaknessMultiplier;
}
