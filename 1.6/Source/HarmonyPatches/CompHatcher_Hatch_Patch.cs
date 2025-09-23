using HarmonyLib;
using RimWorld;

namespace Biotechnology
{
    [HarmonyPatch(typeof(CompHatcher), "Hatch")]
    public static class CompHatcher_Hatch_Patch
    {
        public static void Prefix(CompHatcher __instance)
        {
            var extension = __instance.parent.def.GetModExtension<HatcherExtension>();
            if (extension != null && extension.hatcheeForcePlayerFaction)
            {
                __instance.hatcheeFaction = Faction.OfPlayer;
            }
        }
    }
}
