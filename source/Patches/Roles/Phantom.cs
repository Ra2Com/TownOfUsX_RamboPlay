using TownOfUs.Extensions;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Phantom : Role
    {
        public bool Caught;
        public bool CompletedTasks;
        public bool Faded;

        public Phantom(PlayerControl player) : base(player)
        {
            Name = "幻影";
            ImpostorText = () => "";
            TaskText = () => "在被抓住前做完任务";
            Color = Patches.Colors.Phantom;
            RoleType = RoleEnum.Phantom;
            AddToRoleHistory(RoleType);
            Faction = Faction.Neutral;
        }

        public void Loses()
        {
            LostByRPC = true;
        }

        public void Fade()
        {
            Faded = true;
            var color = new Color(1f, 1f, 1f, 0f);


            var maxDistance = ShipStatus.Instance.MaxLightRadius * PlayerControl.GameOptions.CrewLightMod;

            if (PlayerControl.LocalPlayer == null)
                return;

            var distance = (PlayerControl.LocalPlayer.GetTruePosition() - Player.GetTruePosition()).magnitude;

            var distPercent = distance / maxDistance;
            distPercent = Mathf.Max(0, distPercent - 1);

            var velocity = Player.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude;
            color.a = 0.07f + velocity / Player.MyPhysics.TrueGhostSpeed * 0.13f;
            color.a = Mathf.Lerp(color.a, 0, distPercent);

            if (Player.GetCustomOutfitType() != CustomPlayerOutfitType.PlayerNameOnly)
            {
                Player.SetOutfit(CustomPlayerOutfitType.PlayerNameOnly, new GameData.PlayerOutfit()
                {
                    ColorId = Player.GetDefaultOutfit().ColorId,
                    HatId = "",
                    SkinId = "",
                    VisorId = "",
                    _playerName = ""
                });
            }

            Player.MyRend.color = color;
            Player.nameText.color = Color.clear;

        }
    }
}