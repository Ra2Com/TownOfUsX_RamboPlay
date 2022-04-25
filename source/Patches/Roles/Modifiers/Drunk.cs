using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Drunk : Modifier
    {
        public Drunk(PlayerControl player) : base(player)
        {
            Name = "醉鬼";
            TaskText = () => "我..晕了.. 移动方向相反！";
            Color = Patches.Colors.Drunk;
            ModifierType = ModifierEnum.Drunk;
        }
    }
}