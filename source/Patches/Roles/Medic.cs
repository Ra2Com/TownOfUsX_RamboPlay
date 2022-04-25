using UnityEngine;

namespace TownOfUs.Roles
{
    public class Medic : Role
    {
        public Medic(PlayerControl player) : base(player)
        {
            Name = "医生";
            ImpostorText = () => "给一名船员护盾";
            TaskText = () => "保护一名船员";
            Color = Patches.Colors.Medic;
            RoleType = RoleEnum.Medic;
            AddToRoleHistory(RoleType);
            ShieldedPlayer = null;
        }

        public PlayerControl ClosestPlayer;
        public bool UsedAbility { get; set; } = false;
        public PlayerControl ShieldedPlayer { get; set; }
        public PlayerControl exShielded { get; set; }
    }
}