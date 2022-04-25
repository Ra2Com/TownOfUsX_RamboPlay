using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Bait : Modifier
    {
        public Bait(PlayerControl player) : base(player)
        {
            Name = "诱饵";
            TaskText = () => "杀死你的人会被迫自报";
            Color = Patches.Colors.Bait;
            ModifierType = ModifierEnum.Bait;
        }
    }
}