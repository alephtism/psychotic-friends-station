using Robust.Shared.Configuration;

namespace Content.Shared._PFNStation.CVars;

[CVarDefs]
public sealed class CCVars_PFN
{
    public static readonly CVarDef<bool> RulesPopupEnabled =
        CVarDef.Create<bool>("rules.popup_enabled",true, CVar.SERVER | CVar.REPLICATED);
}
