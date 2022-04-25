using System;

namespace TownOfUs.Roles
{
    public class Blackmailer : Role
    {
        public KillButton _blackmailButton;
        
        public PlayerControl ClosestPlayer;
        public PlayerControl Blackmailed;
        public DateTime LastBlackmailed { get; set; }

        public Blackmailer(PlayerControl player) : base(player)
        {
            Name = "勒索者";
            ImpostorText = () => "让一名玩家会议时无法发言！";
            TaskText = () => "禁言玩家";
            Color = Patches.Colors.Impostor;
            LastBlackmailed = DateTime.UtcNow;
            RoleType = RoleEnum.Blackmailer;
            AddToRoleHistory(RoleType);
            Faction = Faction.Impostors;
        }

        public KillButton BlackmailButton
        {
            get => _blackmailButton;
            set
            {
                _blackmailButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }
        public float BlackmailTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastBlackmailed;
            var num = CustomGameOptions.BlackmailCd * 1000f;
            var flag2 = num - (float)timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float)timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}