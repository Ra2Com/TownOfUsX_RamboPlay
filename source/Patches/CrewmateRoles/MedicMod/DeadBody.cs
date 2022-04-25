using System;
using System.Collections.Generic;
using TownOfUs.Extensions;

namespace TownOfUs.CrewmateRoles.MedicMod
{
    public class DeadPlayer
    {
        public byte KillerId { get; set; }
        public byte PlayerId { get; set; }
        public DateTime KillTime { get; set; }
    }

    //body report class for when medic reports a body
    public class BodyReport
    {
        public PlayerControl Killer { get; set; }
        public PlayerControl Reporter { get; set; }
        public PlayerControl Body { get; set; }
        public float KillAge { get; set; }

        public static string ParseBodyReport(BodyReport br)
        {
            //System.Console.WriteLine(br.KillAge);
            if (br.KillAge > CustomGameOptions.MedicReportColorDuration * 1000)
                return
                    $"尸检报告：尸体死亡时间过长，无法获得有效信息！ (在 {Math.Round(br.KillAge / 1000)}秒前)";

            if (br.Killer.PlayerId == br.Body.PlayerId)
                return
                    $"尸检报告：这是自杀! (在 {Math.Round(br.KillAge / 1000)}秒前)";

            if (br.KillAge < CustomGameOptions.MedicReportNameDuration * 1000)
                return
                    $"尸检报告：凶手是 {br.Killer.Data.PlayerName}! (在 {Math.Round(br.KillAge / 1000)}秒前)";

            var colors = new Dictionary<int, string>
            {
                {0, "深色"},// red
                {1, "深色"},// blue
                {2, "深色"},// green
                {3, "浅色"},// pink
                {4, "浅色"},// orange
                {5, "浅色"},// yellow
                {6, "深色"},// black
                {7, "浅色"},// white
                {8, "深色"},// purple
                {9, "深色"},// brown
                {10, "浅色"},// cyan
                {11, "浅色"},// lime
                {12, "深色"},// maroon
                {13, "浅色"},// rose
                {14, "浅色"},// banana
                {15, "深色"},// gray
                {16, "深色"},// tan
                {17, "浅色"},// coral
                {18, "深色"},// watermelon
                {19, "深色"},// chocolate
                {20, "浅色"},// sky blue
                {21, "深色"},// beige
                {22, "浅色"},// hot pink
                {23, "浅色"},// turquoise
                {24, "浅色"},// lilac
                {25, "深色"},// olive
                {26, "浅色"},// azure
                {27, "浅色"},// rainbow
            };
            var typeOfColor = colors[br.Killer.GetDefaultOutfit().ColorId];
            return
                $"尸检报告：凶手的颜色是 {typeOfColor} 类型. (在 {Math.Round(br.KillAge / 1000)}秒前)";
        }
    }
}
