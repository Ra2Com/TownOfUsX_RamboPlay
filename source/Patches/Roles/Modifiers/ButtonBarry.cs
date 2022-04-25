using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class ButtonBarry : Modifier
    {
        public KillButton ButtonButton;

        public bool ButtonUsed;

        public ButtonBarry(PlayerControl player) : base(player)
        {
            Name = "按钮人";
            TaskText = () => "随时召开会议!";
            Color = Patches.Colors.ButtonBarry;
            ModifierType = ModifierEnum.ButtonBarry;
        }
    }
}