using UnityEngine;

namespace TownOfUs.Roles
{
    public class Spy : Role
    {
        public Spy(PlayerControl player) : base(player)
        {
            Name = "间谍";
            ImpostorText = () => "把伪装者揪出来";
            TaskText = () => "找到伪装者，票出去他们:=D";
            Color = Patches.Colors.Spy;
            RoleType = RoleEnum.Spy;
            AddToRoleHistory(RoleType);
        }
    }
}