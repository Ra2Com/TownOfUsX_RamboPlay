using HarmonyLib;
using Hazel;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.NeutralRoles.ExecutionerMod
{
    public enum OnTargetDead
    {
        Crew,
        Amnesiac,
        Survivor,
        Jester
    }

    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class TargetColor
    {
        private static void UpdateMeeting(MeetingHud __instance, Executioner role)
        {
            foreach (var player in __instance.playerStates)
                if (player.TargetPlayerId == role.target.PlayerId)
                    player.NameText.color = Color.black;
        }

        private static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Executioner)) return;
            if (PlayerControl.LocalPlayer.Data.IsDead) return;

            var role = Role.GetRole<Executioner>(PlayerControl.LocalPlayer);

            if (MeetingHud.Instance != null) UpdateMeeting(MeetingHud.Instance, role);

            role.target.nameText.color = Color.black;

            if (!role.target.Data.IsDead && !role.target.Data.Disconnected) return;
            if (role.TargetVotedOut) return;

            var writer = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                (byte)CustomRPC.ExecutionerToJester, SendOption.Reliable, -1);
            writer.Write(PlayerControl.LocalPlayer.PlayerId);
            AmongUsClient.Instance.FinishRpcImmediately(writer);

            ExeToJes(PlayerControl.LocalPlayer);
        }

        public static void ExeToJes(PlayerControl player)
        {
            player.myTasks.RemoveAt(0);
            Role.RoleDictionary.Remove(player.PlayerId);


            if (CustomGameOptions.OnTargetDead == OnTargetDead.Jester)
            {
                var jester = new Jester(player);
                var task = new GameObject("小丑任务").AddComponent<ImportantTextTask>();
                task.transform.SetParent(player.transform, false);
                task.Text =
                    $"{jester.ColorString}Role: {jester.Name}\n你的目标死了!想办法让自己被投出去!\n假任务:";
                player.myTasks.Insert(0, task);
            }
            else if (CustomGameOptions.OnTargetDead == OnTargetDead.Amnesiac)
            {
                var amnesiac = new Amnesiac(player);
                var task = new GameObject("失忆者任务").AddComponent<ImportantTextTask>();
                task.transform.SetParent(player.transform, false);
                task.Text =
                    $"{amnesiac.ColorString}Role: {amnesiac.Name}\n你的目标死了!现在去偷别人的身份吧!\n假任务:";
                player.myTasks.Insert(0, task);
            }
            else if (CustomGameOptions.OnTargetDead == OnTargetDead.Survivor)
            {
                var surv = new Survivor(player);
                var task = new GameObject("投机主义者任务").AddComponent<ImportantTextTask>();
                task.transform.SetParent(player.transform, false);
                task.Text =
                    $"{surv.ColorString}Role: {surv.Name}\n你的目标被杀了。现在你只需要活着！";
                player.myTasks.Insert(0, task);
            }
            else
            {
                new Crewmate(player);
            }
        }
    }
}