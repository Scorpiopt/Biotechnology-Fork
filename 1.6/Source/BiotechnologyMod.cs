using HarmonyLib;
using Verse;

namespace Biotechnology
{
    public class BiotechnologyMod : Mod
    {
        public BiotechnologyMod(ModContentPack content) : base(content)
        {
            new Harmony("BiotechnologyAutoAnimalPatch.Mod").PatchAll();
        }
    }
}
