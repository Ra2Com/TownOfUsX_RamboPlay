using System.Collections.Generic;
using System.Linq;
using TMPro;
using TownOfUs.Patches;
using UnityEngine;
using Hazel;
using TownOfUs.NeutralRoles.ExecutionerMod;
using TownOfUs.NeutralRoles.GuardianAngelMod;

namespace TownOfUs.Roles.Modifiers
{
    public class Assassin : Ability
    {
        public Dictionary<byte, (GameObject, GameObject, GameObject, TMP_Text)> Buttons = new Dictionary<byte, (GameObject, GameObject, GameObject, TMP_Text)>();


        private Dictionary<string, Color> ColorMapping = new Dictionary<string, Color>();

        public Dictionary<string, Color> SortedColorMapping;

        public Dictionary<byte, string> Guesses = new Dictionary<byte, string>();


        public Assassin(PlayerControl player) : base(player)
        {
            Name = "刺客";
            TaskText = () => "杀死好人";
            Color = Patches.Colors.Impostor;
            AbilityType = AbilityEnum.Assassin;

            RemainingKills = CustomGameOptions.AssassinKills;

            // Adds all the roles that have a non-zero chance of being in the game.
            if (CustomGameOptions.MayorOn > 0) ColorMapping.Add("市长", Colors.Mayor);
            if (CustomGameOptions.SheriffOn > 0) ColorMapping.Add("警长", Colors.Sheriff);
            if (CustomGameOptions.EngineerOn > 0) ColorMapping.Add("工程师", Colors.Engineer);
            if (CustomGameOptions.SwapperOn > 0) ColorMapping.Add("换票师", Colors.Swapper);
            if (CustomGameOptions.InvestigatorOn > 0) ColorMapping.Add("侦探", Colors.Investigator);
            if (CustomGameOptions.TimeLordOn > 0) ColorMapping.Add("时间之主", Colors.TimeLord);
            if (CustomGameOptions.MedicOn > 0) ColorMapping.Add("医生", Colors.Medic);
            if (CustomGameOptions.SeerOn > 0) ColorMapping.Add("预言师", Colors.Seer);
            if (CustomGameOptions.SpyOn > 0) ColorMapping.Add("间谍", Colors.Spy);
            if (CustomGameOptions.SnitchOn > 0 && !CustomGameOptions.AssassinSnitchViaCrewmate) ColorMapping.Add("告密者", Colors.Snitch);
            if (CustomGameOptions.AltruistOn > 0) ColorMapping.Add("殉道师", Colors.Altruist);
            if (CustomGameOptions.VigilanteOn > 0) ColorMapping.Add("侠客", Colors.Vigilante);
            if (CustomGameOptions.VeteranOn > 0) ColorMapping.Add("老兵", Colors.Veteran);
            if (CustomGameOptions.TrackerOn > 0) ColorMapping.Add("追踪者", Colors.Tracker);
            if (CustomGameOptions.TransporterOn > 0) ColorMapping.Add("传送师", Colors.Transporter);
            if (CustomGameOptions.MediumOn > 0) ColorMapping.Add("通灵师", Colors.Medium);
            if (CustomGameOptions.MysticOn > 0) ColorMapping.Add("灵媒", Colors.Mystic);

            // Add Neutral roles if enabled
            if (CustomGameOptions.AssassinGuessNeutralBenign)
            {
                if (CustomGameOptions.AmnesiacOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Amnesiac) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Amnesiac)) ColorMapping.Add("失忆者", Colors.Amnesiac);
                if (CustomGameOptions.GuardianAngelOn > 0) ColorMapping.Add("守护天使", Colors.GuardianAngel);
                if (CustomGameOptions.SurvivorOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Survivor) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Survivor)) ColorMapping.Add("投机主义者", Colors.Survivor);
            }
            if (CustomGameOptions.AssassinGuessNeutralEvil)
            {
                if (CustomGameOptions.ExecutionerOn > 0) ColorMapping.Add("行刑者", Colors.Executioner);
                if (CustomGameOptions.JesterOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Jester) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Jester)) ColorMapping.Add("小丑", Colors.Jester);
            }
            if (CustomGameOptions.AssassinGuessNeutralKilling)
            {
                if (CustomGameOptions.ArsonistOn > 0) ColorMapping.Add("纵火犯", Colors.Arsonist);
                if (CustomGameOptions.GlitchOn > 0) ColorMapping.Add("混沌", Colors.Glitch);
                if (CustomGameOptions.GlitchOn > 0) ColorMapping.Add("天启", Colors.Juggernaut);
            }

            // Add vanilla crewmate if enabled
            if (CustomGameOptions.AssassinCrewmateGuess) ColorMapping.Add("船员", Colors.Crewmate);

            // Sorts the list alphabetically. 
            SortedColorMapping = ColorMapping.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public bool GuessedThisMeeting { get; set; } = false;

        public int RemainingKills { get; set; }

        public List<string> PossibleGuesses => SortedColorMapping.Keys.ToList();
    }
}
