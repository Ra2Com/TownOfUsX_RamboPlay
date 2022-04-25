using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Torch : Modifier
    {
        public Torch(PlayerControl player) : base(player)
        {
            Name = "火炬";
            TaskText = () => "黑暗时你的视野也不会变小！";
            Color = Patches.Colors.Torch;
            ModifierType = ModifierEnum.Torch;
        }
    }
}