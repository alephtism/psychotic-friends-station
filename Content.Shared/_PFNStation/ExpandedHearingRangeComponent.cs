namespace Content.Shared._PFNStation;

/// <summary>
/// This is used for increasing the range at which entities recieve local chat messages.
/// </summary>
[RegisterComponent]
public sealed partial class ExpandedHearingRangeComponent : Component
{
    [DataField]
    public float HearingRange = 0f;
}
