using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Linq;
using Reactor.Extensions;
using TownOfUs.Roles;

namespace TownOfUs.Patches {

    static class AdditionalTempData {
        public static List<PlayerRoleInfo> playerRoles = new List<PlayerRoleInfo>();

        public static void clear() {
            playerRoles.Clear();
        }

        internal class PlayerRoleInfo {
            public string PlayerName { get; set; }
            public string Role {get;set;}
        }
    }


    [HarmonyPatch(typeof(AmongUsClient), nameof(AmongUsClient.OnGameEnd))]
    public class OnGameEndPatch {

        public static void Postfix(AmongUsClient __instance, [HarmonyArgument(0)] EndGameResult endGameResult)
        {
            AdditionalTempData.clear();
            var playerRole = "";
            // Theres a better way of doing this e.g. switch statement or dictionary. But this works for now.
            foreach (var playerControl in PlayerControl.AllPlayerControls)
            {
                playerRole = "";
                foreach (var role in Role.RoleHistory.Where(x => x.Key == playerControl.PlayerId))
                {
                    if (role.Value == RoleEnum.Crewmate) {playerRole += "<color=#"+Patches.Colors.Crewmate.ToHtmlStringRGBA()+">船员</color> > ";}
                    else if (role.Value == RoleEnum.Impostor) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">伪装者</color> > ";}
                    else if (role.Value == RoleEnum.Altruist) {playerRole += "<color=#"+Patches.Colors.Altruist.ToHtmlStringRGBA()+">殉道师</color> > ";}
                    else if (role.Value == RoleEnum.Engineer) {playerRole += "<color=#"+Patches.Colors.Engineer.ToHtmlStringRGBA()+">工程师</color> > ";}
                    else if (role.Value == RoleEnum.Investigator) {playerRole += "<color=#"+Patches.Colors.Investigator.ToHtmlStringRGBA()+">侦探</color> > ";}
                    else if (role.Value == RoleEnum.Mayor) {playerRole += "<color=#"+Patches.Colors.Mayor.ToHtmlStringRGBA()+">市长</color> > ";}
                    else if (role.Value == RoleEnum.Medic) {playerRole += "<color=#"+Patches.Colors.Medic.ToHtmlStringRGBA()+">医生</color> > ";}
                    else if (role.Value == RoleEnum.Sheriff) {playerRole += "<color=#"+Patches.Colors.Sheriff.ToHtmlStringRGBA()+">警长</color> > ";}
                    else if (role.Value == RoleEnum.Swapper) {playerRole += "<color=#"+Patches.Colors.Swapper.ToHtmlStringRGBA()+">换票师</color> > ";}
                    else if (role.Value == RoleEnum.TimeLord) {playerRole += "<color=#"+Patches.Colors.TimeLord.ToHtmlStringRGBA()+">时间之主</color> > ";}
                    else if (role.Value == RoleEnum.Seer) {playerRole += "<color=#"+Patches.Colors.Seer.ToHtmlStringRGBA()+">预言家</color> > ";}
                    else if (role.Value == RoleEnum.Snitch) {playerRole += "<color=#"+Patches.Colors.Snitch.ToHtmlStringRGBA()+">告密者</color> > ";}
                    else if (role.Value == RoleEnum.Spy) {playerRole += "<color=#"+Patches.Colors.Spy.ToHtmlStringRGBA()+">间谍</color> > ";}
                    else if (role.Value == RoleEnum.Vigilante) {playerRole += "<color=#"+Patches.Colors.Vigilante.ToHtmlStringRGBA()+">侠客</color> > "; }
                    else if (role.Value == RoleEnum.Arsonist) {playerRole += "<color=#"+Patches.Colors.Arsonist.ToHtmlStringRGBA()+">纵火犯</color> > ";}
                    else if (role.Value == RoleEnum.Executioner) {playerRole += "<color=#"+Patches.Colors.Executioner.ToHtmlStringRGBA()+">行刑者</color> > ";}
                    else if (role.Value == RoleEnum.Glitch) {playerRole += "<color=#"+Patches.Colors.Glitch.ToHtmlStringRGBA()+">混沌</color> > ";}
                    else if (role.Value == RoleEnum.Jester) {playerRole += "<color=#"+Patches.Colors.Jester.ToHtmlStringRGBA()+">小丑</color> > ";}
                    else if (role.Value == RoleEnum.Phantom) {playerRole += "<color=#"+Patches.Colors.Phantom.ToHtmlStringRGBA()+">幻影</color> > ";}
                    //else if (role.Value == RoleEnum.Assassin) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">刺客</color> > ";}
                    //else if (role.Value == RoleEnum.Camouflager) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">隐蔽者</color> > ";}
                    else if (role.Value == RoleEnum.Grenadier) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">掷弹兵</color> > ";}
                    else if (role.Value == RoleEnum.Janitor) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">清理者</color> > ";}
                    else if (role.Value == RoleEnum.Miner) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">管道工</color> > ";}
                    else if (role.Value == RoleEnum.Morphling) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">化形者</color> > ";}
                    else if (role.Value == RoleEnum.Swooper) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">隐身人</color> > ";}
                    else if (role.Value == RoleEnum.Underdog) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">潜伏者</color> > ";}
                    else if (role.Value == RoleEnum.Undertaker) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">送葬者</color> > "; }
                    else if (role.Value == RoleEnum.Haunter) { playerRole += "<color=#"+Patches.Colors.Haunter.ToHtmlStringRGBA()+">冤魂</color> > "; }
                    else if (role.Value == RoleEnum.Grenadier) { playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">掷弹兵</color> > "; }
                    else if (role.Value == RoleEnum.Veteran) { playerRole += "<color=#"+Patches.Colors.Veteran.ToHtmlStringRGBA()+">老兵</color> > "; }
                    else if (role.Value == RoleEnum.Amnesiac) { playerRole += "<color=#"+Patches.Colors.Amnesiac.ToHtmlStringRGBA()+">失忆者</color> > "; }
                    else if (role.Value == RoleEnum.Juggernaut) { playerRole += "<color=#"+Patches.Colors.Juggernaut.ToHtmlStringRGBA()+">天启</color> > "; }
                    else if (role.Value == RoleEnum.Tracker) { playerRole += "<color=#"+Patches.Colors.Tracker.ToHtmlStringRGBA()+">追踪者</color> > "; }
                    else if (role.Value == RoleEnum.Poisoner) { playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">绝命毒师</color> > "; }
                    else if (role.Value == RoleEnum.Transporter) { playerRole += "<color=#" + Patches.Colors.Transporter.ToHtmlStringRGBA() + ">传送师</color> > "; }
                    else if (role.Value == RoleEnum.Traitor) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">背叛者</color> > "; }
                    else if (role.Value == RoleEnum.Medium) { playerRole += "<color=#" + Patches.Colors.Medium.ToHtmlStringRGBA() + ">通灵师</color> > "; }
                    else if (role.Value == RoleEnum.Survivor) { playerRole += "<color=#" + Patches.Colors.Survivor.ToHtmlStringRGBA() + ">投机主义者</color> > "; }
                    else if (role.Value == RoleEnum.GuardianAngel) { playerRole += "<color=#" + Patches.Colors.GuardianAngel.ToHtmlStringRGBA() + ">守护天使</color> > "; }
                    else if (role.Value == RoleEnum.Mystic) { playerRole += "<color=#" + Patches.Colors.Mystic.ToHtmlStringRGBA() + ">灵媒</color> > "; }
                    else if (role.Value == RoleEnum.Blackmailer) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">勒索者</color> > "; }
                }
                playerRole = playerRole.Remove(playerRole.Length - 3);

                if (playerControl.Is(ModifierEnum.Giant)) {
                    playerRole += " (<color=#" + Patches.Colors.Giant.ToHtmlStringRGBA() + ">巨人</color>)";
                } else if (playerControl.Is(ModifierEnum.ButtonBarry)) {
                    playerRole += " (<color=#" + Patches.Colors.ButtonBarry.ToHtmlStringRGBA() + ">按钮人</color>)";
                } else if (playerControl.Is(ModifierEnum.Bait)) {
                    playerRole += " (<color=#" + Patches.Colors.Bait.ToHtmlStringRGBA() + ">诱饵</color>)";
                } else if (playerControl.Is(ModifierEnum.Diseased)) {
                    playerRole += " (<color=#" + Patches.Colors.Diseased.ToHtmlStringRGBA() + ">病人</color>)";
                } else if (playerControl.Is(ModifierEnum.Drunk)) {
                    playerRole += " (<color=#" + Patches.Colors.Drunk.ToHtmlStringRGBA() + ">醉鬼</color>)";
                } else if (playerControl.Is(ModifierEnum.Flash)) {
                    playerRole += " (<color=#" + Patches.Colors.Flash.ToHtmlStringRGBA() + ">闪电侠</color>)";
                } else if (playerControl.Is(ModifierEnum.Tiebreaker)) {
                    playerRole += " (<color=#" + Patches.Colors.Tiebreaker.ToHtmlStringRGBA() + ">破平者</color>)";
                } else if (playerControl.Is(ModifierEnum.Torch)) {
                    playerRole += " (<color=#" + Patches.Colors.Torch.ToHtmlStringRGBA() + ">火炬</color>)";
                } else if (playerControl.Is(ModifierEnum.Lover)) {
                    playerRole += " (<color=#" + Patches.Colors.Lovers.ToHtmlStringRGBA() + ">恋人</color>)";
                } else if (playerControl.Is(ModifierEnum.Sleuth)) {
                    playerRole += " (<color=#" + Patches.Colors.Sleuth.ToHtmlStringRGBA() + ">掘墓人</color>)";
                }  
                AdditionalTempData.playerRoles.Add(new AdditionalTempData.PlayerRoleInfo() { PlayerName = playerControl.Data.PlayerName, Role = playerRole });
            }
        }
    }

    [HarmonyPatch(typeof(EndGameManager), nameof(EndGameManager.SetEverythingUp))]
    public class EndGameManagerSetUpPatch {
        public static void Postfix(EndGameManager __instance) {
            GameObject bonusText = UnityEngine.Object.Instantiate(__instance.WinText.gameObject);
            bonusText.transform.position = new Vector3(__instance.WinText.transform.position.x, __instance.WinText.transform.position.y - 0.8f, __instance.WinText.transform.position.z);
            bonusText.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
            TMPro.TMP_Text textRenderer = bonusText.GetComponent<TMPro.TMP_Text>();
            textRenderer.text = "";

            var position = Camera.main.ViewportToWorldPoint(new Vector3(0f, 1f, Camera.main.nearClipPlane));
            GameObject roleSummary = UnityEngine.Object.Instantiate(__instance.WinText.gameObject);
            roleSummary.transform.position = new Vector3(__instance.Navigation.ExitButton.transform.position.x + 0.1f, position.y - 0.1f, -14f); 
            roleSummary.transform.localScale = new Vector3(1f, 1f, 1f);

            var roleSummaryText = new StringBuilder();
            roleSummaryText.AppendLine("End game summary:");
            foreach(var data in AdditionalTempData.playerRoles) {
                var role = string.Join(" ", data.Role);
                roleSummaryText.AppendLine($"{data.PlayerName} - {role}");
            }
            TMPro.TMP_Text roleSummaryTextMesh = roleSummary.GetComponent<TMPro.TMP_Text>();
            roleSummaryTextMesh.alignment = TMPro.TextAlignmentOptions.TopLeft;
            roleSummaryTextMesh.color = Color.white;
            roleSummaryTextMesh.fontSizeMin = 1.5f;
            roleSummaryTextMesh.fontSizeMax = 1.5f;
            roleSummaryTextMesh.fontSize = 1.5f;
             
            var roleSummaryTextMeshRectTransform = roleSummaryTextMesh.GetComponent<RectTransform>();
            roleSummaryTextMeshRectTransform.anchoredPosition = new Vector2(position.x + 3.5f, position.y - 0.1f);
            roleSummaryTextMesh.text = roleSummaryText.ToString();
            AdditionalTempData.clear();
        }
    }
}