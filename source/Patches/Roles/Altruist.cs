using UnityEngine;

namespace TownOfUs.Roles
{
    public class Altruist : Role
    {
        public bool CurrentlyReviving;
        public DeadBody CurrentTarget;

        public bool ReviveUsed;

        public Altruist(PlayerControl player) : base(player)
        {
            Name = "殉道师";
            ImpostorText = () => "舍己为人";
            TaskText = () => "拯救尸体，但是要搭上自己的姓名！";
            Color = Patches.Colors.Altruist;
            RoleType = RoleEnum.Altruist;
            AddToRoleHistory(RoleType);
        }
    }
}