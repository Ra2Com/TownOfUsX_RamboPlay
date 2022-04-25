using HarmonyLib;
using UnhollowerBaseLib;

namespace TownOfUs.RainbowMod
{
    [HarmonyPatch(typeof(TranslationController), nameof(TranslationController.GetString),
        new[] { typeof(StringNames), typeof(Il2CppReferenceArray<Il2CppSystem.Object>) })]
    public class PatchColours
    {
        public static bool Prefix(ref string __result, [HarmonyArgument(0)] StringNames name)
        {
            var newResult = (int)name switch
            {
                999990 => "西瓜红",
                999991 => "巧克力",
                999992 => "天蓝色",
                999993 => "浅褐",
                999994 => "热粉",
                999995 => "绿松色",
                999996 => "淡紫",
                999997 => "橄榄色",
                999998 => "蔚蓝色",
                999999 => "彩色",
                _ => null
            };
            if (newResult != null)
            {
                __result = newResult;
                return false;
            }

            return true;
        }
    }
}
