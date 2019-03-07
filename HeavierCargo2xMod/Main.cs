using System;
using System.Reflection;
using UnityModManagerNet;
using Harmony12;
using UnityEngine;

namespace HeavierCargo2xMod
{
    public class Main
    {
        static bool Load(UnityModManager.ModEntry modEntry)
        {
            var harmony = HarmonyInstance.Create(modEntry.Info.Id);
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            // Something
            return true; // If false the mod will show an error.
        }
    }

    [HarmonyPatch(typeof(DV.Logic.Job.CargoTypes), "GetCargoMass")]
    class DVLogicJobCargoTypes_GetCargoMass_Patch
    {
        static void Postfix(ref float __result)
        {
            __result = __result * 2f;
        }
    }

    [HarmonyPatch(typeof(DV.Logic.Job.CargoTypes), "GetCargoUnitMass")]
    class DVLogicJobCargoTypes_GetCargoUnitMass_Patch
    {
        static void Postfix(ref float __result)
        {
            __result = __result * 2f;
        }
    }
}