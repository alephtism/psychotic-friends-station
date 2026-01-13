using Content.Shared._Goobstation.Flashbang;
using Content.Shared.Actions;
using Content.Shared.Inventory;

namespace Content.Shared._PFNStation.Flash;

/// <summary>
/// This handles multiplying the flashbang duration outside of a Switchable Overlay.
/// This will probably be replaced at a later date, as I really do not like having to work around it like this, but it works for now.
/// </summary>
public abstract class FlashDurationMultiplierSystem<TComp, TEvent> : EntitySystem
    where TComp :  FlashWeaknessComponent
    where TEvent : InstantActionEvent
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<TComp, FlashDurationMultiplierEvent>(OnGetFlashMultiplier);
        SubscribeLocalEvent<TComp, InventoryRelayedEvent<FlashDurationMultiplierEvent>>(OnGetInventoryFlashMultiplier);
    }

    private void OnGetInventoryFlashMultiplier(Entity<TComp> ent,
        ref InventoryRelayedEvent<FlashDurationMultiplierEvent> args)
    {
        args.Args.Multiplier *= GetFlashMultiplier(ent);
    }

    private void OnGetFlashMultiplier(Entity<TComp> ent, ref FlashDurationMultiplierEvent args)
    {
        args.Multiplier *= GetFlashMultiplier(ent);

    }

    private float GetFlashMultiplier(TComp comp)
    {
        return comp.FlashWeaknessMultiplier;
    }
}
