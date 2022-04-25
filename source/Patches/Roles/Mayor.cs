using System.Collections.Generic;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Mayor : Role
    {
        public List<byte> ExtraVotes = new List<byte>();

        public Mayor(PlayerControl player) : base(player)
        {
            Name = "市长";
            ImpostorText = () => "积攒票数";
            TaskText = () => "积攒票数，一次票完！";
            Color = Patches.Colors.Mayor;
            RoleType = RoleEnum.Mayor;
            AddToRoleHistory(RoleType);
            VoteBank = CustomGameOptions.MayorVoteBank;
        }

        public int VoteBank { get; set; }
        public bool SelfVote { get; set; }

        public bool VotedOnce { get; set; }

        public PlayerVoteArea Abstain { get; set; }

        public bool CanVote => VoteBank > 0 && !SelfVote;
    }
}