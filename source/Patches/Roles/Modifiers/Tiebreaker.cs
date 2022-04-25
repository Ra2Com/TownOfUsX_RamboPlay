using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Tiebreaker : Modifier
    {
        public Tiebreaker(PlayerControl player) : base(player)
        {
            Name = "破平者";
            TaskText = () => "当票数相同时，你投的人将被驱逐";
            Color = Patches.Colors.Tiebreaker;
            ModifierType = ModifierEnum.Tiebreaker;
        }
    }
}