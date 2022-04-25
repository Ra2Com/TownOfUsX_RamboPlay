using UnityEngine;

namespace TownOfUs.Roles
{
    public class Impostor : Role
    {
        public Impostor(PlayerControl player) : base(player)
        {
            Name = "伪装者";
            Hidden = true;
            Faction = Faction.Impostors;
            RoleType = RoleEnum.Impostor;
            AddToRoleHistory(RoleType);
            Color = Palette.ImpostorRed;
        }
    }

    public class Crewmate : Role
    {
        public Crewmate(PlayerControl player) : base(player)
        {
            Name = "船员";
            Hidden = true;
            Faction = Faction.Crewmates;
            RoleType = RoleEnum.Crewmate;
            AddToRoleHistory(RoleType);
            Color = Patches.Colors.Crewmate;
        }
    }
}