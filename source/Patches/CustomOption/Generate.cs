using System;

namespace TownOfUs.CustomOption
{
    public class Generate
    {
        public static CustomHeaderOption CrewInvestigativeRoles;
        public static CustomNumberOption HaunterOn;
        public static CustomNumberOption InvestigatorOn;
        public static CustomNumberOption MysticOn;
        public static CustomNumberOption SeerOn;
        public static CustomNumberOption SnitchOn;
        public static CustomNumberOption SpyOn;
        public static CustomNumberOption TrackerOn;

        public static CustomHeaderOption CrewProtectiveRoles;
        public static CustomNumberOption AltruistOn;
        public static CustomNumberOption MedicOn;

        public static CustomHeaderOption CrewKillingRoles;
        public static CustomNumberOption SheriffOn;
        public static CustomNumberOption VeteranOn;
        public static CustomNumberOption VigilanteOn;

        public static CustomHeaderOption CrewSupportRoles;
        public static CustomNumberOption EngineerOn;
        public static CustomNumberOption MayorOn;
        public static CustomNumberOption MediumOn;
        public static CustomNumberOption SwapperOn;
        public static CustomNumberOption TimeLordOn;
        public static CustomNumberOption TransporterOn;

        public static CustomHeaderOption NeutralBenignRoles;
        public static CustomNumberOption AmnesiacOn;
        public static CustomNumberOption GuardianAngelOn;
        public static CustomNumberOption SurvivorOn;

        public static CustomHeaderOption NeutralEvilRoles;
        public static CustomNumberOption ExecutionerOn;
        public static CustomNumberOption JesterOn;
        public static CustomNumberOption PhantomOn;

        public static CustomHeaderOption NeutralKillingRoles;
        public static CustomNumberOption GlitchOn;
        public static CustomNumberOption ArsonistOn;

        public static CustomHeaderOption ImpostorConcealingRoles;
        public static CustomNumberOption MorphlingOn;
        public static CustomNumberOption SwooperOn;
        public static CustomNumberOption GrenadierOn;

        public static CustomHeaderOption ImpostorKillingRoles;
        public static CustomNumberOption PoisonerOn;
        public static CustomNumberOption TraitorOn;
        public static CustomNumberOption UnderdogOn;

        public static CustomHeaderOption ImpostorSupportRoles;
        public static CustomNumberOption BlackmailerOn;
        public static CustomNumberOption JanitorOn;
        public static CustomNumberOption MinerOn;
        public static CustomNumberOption UndertakerOn;

        public static CustomHeaderOption CrewmateModifiers;
        public static CustomNumberOption BaitOn;
        public static CustomNumberOption DiseasedOn;
        public static CustomNumberOption TorchOn;

        public static CustomHeaderOption GlobalModifiers;
        public static CustomNumberOption ButtonBarryOn;
        public static CustomNumberOption DrunkOn;
        public static CustomNumberOption FlashOn;
        public static CustomNumberOption GiantOn;
        public static CustomNumberOption LoversOn;
        public static CustomNumberOption SleuthOn;
        public static CustomNumberOption TiebreakerOn;

        public static CustomHeaderOption CustomGameSettings;
        public static CustomToggleOption ColourblindComms;
        public static CustomToggleOption ImpostorSeeRoles;
        public static CustomToggleOption DeadSeeRoles;
        public static CustomToggleOption DisableLevels;
        public static CustomToggleOption WhiteNameplates;
        public static CustomNumberOption MaxNeutralRoles;
        public static CustomNumberOption VanillaGame;
        public static CustomNumberOption InitialCooldowns;
        public static CustomToggleOption ParallelMedScans;

        public static CustomHeaderOption TaskTrackingSettings;
        public static CustomToggleOption SeeTasksDuringRound;
        public static CustomToggleOption SeeTasksDuringMeeting;
        public static CustomToggleOption SeeTasksWhenDead;

        public static CustomHeaderOption Mayor;
        public static CustomNumberOption MayorVoteBank;
        public static CustomToggleOption MayorAnonymous;

        public static CustomHeaderOption Sheriff;
        public static CustomToggleOption SheriffKillOther;
        public static CustomToggleOption SheriffKillsJester;
        public static CustomToggleOption SheriffKillsGlitch;
        public static CustomToggleOption SheriffKillsExecutioner;
        public static CustomToggleOption SheriffKillsArsonist;
        public static CustomNumberOption SheriffKillCd;
        public static CustomToggleOption SheriffBodyReport;


        public static CustomHeaderOption Engineer;
        public static CustomStringOption EngineerPer;

        public static CustomHeaderOption Investigator;
        public static CustomNumberOption FootprintSize;
        public static CustomNumberOption FootprintInterval;
        public static CustomNumberOption FootprintDuration;
        public static CustomToggleOption AnonymousFootPrint;
        public static CustomToggleOption VentFootprintVisible;

        public static CustomHeaderOption TimeLord;
        public static CustomToggleOption RewindRevive;
        public static CustomNumberOption RewindDuration;
        public static CustomNumberOption RewindCooldown;
        public static CustomNumberOption RewindMaxUses;
        public static CustomToggleOption TimeLordVitals;

        public static CustomHeaderOption Medic;
        public static CustomStringOption ShowShielded;
        public static CustomStringOption WhoGetsNotification;
        public static CustomToggleOption ShieldBreaks;
        public static CustomToggleOption MedicReportSwitch;
        public static CustomNumberOption MedicReportNameDuration;
        public static CustomNumberOption MedicReportColorDuration;

        public static CustomHeaderOption Seer;
        public static CustomNumberOption SeerCooldown;
        public static CustomToggleOption CrewKillingRed;
        public static CustomToggleOption NeutBenignRed;
        public static CustomToggleOption NeutEvilRed;
        public static CustomToggleOption NeutKillingRed;

        public static CustomHeaderOption Swapper;
        public static CustomToggleOption SwapperButton;

        public static CustomHeaderOption Transporter;
        public static CustomNumberOption TransportCooldown;
        public static CustomNumberOption TransportMaxUses;
        public static CustomToggleOption TransporterVitals;

        public static CustomHeaderOption Jester;
        public static CustomToggleOption JesterButton;
        public static CustomToggleOption JesterVent;

        public static CustomHeaderOption TheGlitch;
        public static CustomNumberOption MimicCooldownOption;
        public static CustomNumberOption MimicDurationOption;
        public static CustomNumberOption HackCooldownOption;
        public static CustomNumberOption HackDurationOption;
        public static CustomNumberOption GlitchKillCooldownOption;
        public static CustomStringOption GlitchHackDistanceOption;
        public static CustomToggleOption GlitchVent;

        public static CustomHeaderOption Morphling;
        public static CustomNumberOption MorphlingCooldown;
        public static CustomNumberOption MorphlingDuration;
        public static CustomToggleOption MorphlingVent;

        public static CustomHeaderOption Executioner;
        public static CustomStringOption OnTargetDead;
        public static CustomToggleOption ExecutionerButton;

        public static CustomHeaderOption Phantom;
        public static CustomNumberOption PhantomTasksRemaining;

        public static CustomHeaderOption Snitch;
        public static CustomToggleOption SnitchOnLaunch;
        public static CustomToggleOption SnitchSeesNeutrals;
        public static CustomNumberOption SnitchTasksRemaining;
        public static CustomToggleOption SnitchSeesImpInMeeting;

        public static CustomHeaderOption Altruist;
        public static CustomNumberOption ReviveDuration;
        public static CustomToggleOption AltruistTargetBody;

        public static CustomHeaderOption Miner;
        public static CustomNumberOption MineCooldown;

        public static CustomHeaderOption Swooper;
        public static CustomNumberOption SwoopCooldown;
        public static CustomNumberOption SwoopDuration;
        public static CustomToggleOption SwooperVent;

        public static CustomHeaderOption Arsonist;
        public static CustomNumberOption DouseCooldown;
        public static CustomToggleOption ArsonistGameEnd;

        public static CustomHeaderOption Undertaker;
        public static CustomNumberOption DragCooldown;
        public static CustomToggleOption UndertakerVent;
        public static CustomToggleOption UndertakerVentWithBody;

        public static CustomHeaderOption Assassin;
        public static CustomNumberOption NumberOfAssassins;
        public static CustomToggleOption AmneTurnAssassin;
        public static CustomToggleOption TraitorCanAssassin;
        public static CustomNumberOption AssassinKills;
        public static CustomToggleOption AssassinMultiKill;
        public static CustomToggleOption AssassinCrewmateGuess;
        public static CustomToggleOption AssassinSnitchViaCrewmate;
        public static CustomToggleOption AssassinGuessNeutralBenign;
        public static CustomToggleOption AssassinGuessNeutralEvil;
        public static CustomToggleOption AssassinGuessNeutralKilling;

        public static CustomHeaderOption Underdog;
        public static CustomNumberOption UnderdogKillBonus;
        public static CustomToggleOption UnderdogIncreasedKC;

        public static CustomHeaderOption Vigilante;
        public static CustomNumberOption VigilanteKills;
        public static CustomToggleOption VigilanteMultiKill;
        public static CustomToggleOption VigilanteGuessNeutralBenign;
        public static CustomToggleOption VigilanteGuessNeutralEvil;
        public static CustomToggleOption VigilanteGuessNeutralKilling;

        public static CustomHeaderOption Haunter;
        public static CustomNumberOption HaunterTasksRemainingClicked;
        public static CustomNumberOption HaunterTasksRemainingAlert;
        public static CustomToggleOption HaunterRevealsNeutrals;
        public static CustomStringOption HaunterCanBeClickedBy;

        public static CustomHeaderOption Grenadier;
        public static CustomNumberOption GrenadeCooldown;
        public static CustomNumberOption GrenadeDuration;
        public static CustomToggleOption GrenadierVent;
        public static CustomNumberOption FlashRadius;

        public static CustomHeaderOption Veteran;
        public static CustomToggleOption KilledOnAlert;
        public static CustomNumberOption AlertCooldown;
        public static CustomNumberOption AlertDuration;
        public static CustomNumberOption MaxAlerts;

        public static CustomHeaderOption Tracker;
        public static CustomNumberOption UpdateInterval;
        public static CustomNumberOption TrackCooldown;
        public static CustomToggleOption ResetOnNewRound;
        public static CustomNumberOption MaxTracks;

        public static CustomHeaderOption Poisoner;
        public static CustomNumberOption PoisonCooldown;
        public static CustomNumberOption PoisonDuration;
        public static CustomToggleOption PoisonerVent;

        public static CustomHeaderOption Traitor;
        public static CustomNumberOption LatestSpawn;
        public static CustomToggleOption GlitchStopsTraitor;

        public static CustomHeaderOption Amnesiac;
        public static CustomToggleOption RememberArrows;
        public static CustomNumberOption RememberArrowDelay;

        public static CustomHeaderOption Medium;
        public static CustomNumberOption MediateCooldown;
        public static CustomToggleOption ShowMediatePlayer;
        public static CustomToggleOption ShowMediumToDead;
        public static CustomStringOption DeadRevealed;

        public static CustomHeaderOption Survivor;
        public static CustomNumberOption VestCd;
        public static CustomNumberOption VestDuration;
        public static CustomNumberOption VestKCReset;
        public static CustomNumberOption MaxVests;

        public static CustomHeaderOption GuardianAngel;
        public static CustomNumberOption ProtectCd;
        public static CustomNumberOption ProtectDuration;
        public static CustomNumberOption ProtectKCReset;
        public static CustomNumberOption MaxProtects;
        public static CustomStringOption ShowProtect;
        public static CustomStringOption GaOnTargetDeath;

        public static CustomHeaderOption Mystic;
        public static CustomNumberOption MysticArrowDuration;

        public static CustomHeaderOption Blackmailer;
        public static CustomNumberOption BlackmailCooldown;

        public static CustomHeaderOption Lovers;
        public static CustomToggleOption BothLoversDie;
        public static CustomNumberOption LovingImpPercent;
        public static CustomToggleOption NeutralLovers;

        public static Func<object, string> PercentFormat { get; } = value => $"{value:0}%";
        private static Func<object, string> CooldownFormat { get; } = value => $"{value:0.0#}s";
        private static Func<object, string> MultiplierFormat { get; } = value => $"{value:0.0#}x";


        public static void GenerateAll()
        {
            var num = 0;

            Patches.ExportButton = new Export(num++);
            Patches.ImportButton = new Import(num++);


            CrewInvestigativeRoles = new CustomHeaderOption(num++, "情报型船员职业");
            HaunterOn = new CustomNumberOption(true, num++, "<color=#D3D3D3FF>冤魂</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            InvestigatorOn = new CustomNumberOption(true, num++, "<color=#00B3B3FF>侦探</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MysticOn = new CustomNumberOption(true, num++, "<color=#4D99E6FF>灵媒</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SeerOn = new CustomNumberOption(true, num++, "<color=#FFCC80FF>告密者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SnitchOn = new CustomNumberOption(true, num++, "<color=#D4AF37FF>预言家</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SpyOn = new CustomNumberOption(true, num++, "<color=#CCA3CCFF>特工</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TrackerOn = new CustomNumberOption(true, num++, "<color=#009900FF>追踪者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewKillingRoles = new CustomHeaderOption(num++, "击杀型船员职业");
            SheriffOn = new CustomNumberOption(true, num++, "<color=#FFFF00FF>警长</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VeteranOn = new CustomNumberOption(true, num++, "<color=#998040FF>老兵</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VigilanteOn = new CustomNumberOption(true, num++, "<color=#FFFF99FF>侠客</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewProtectiveRoles = new CustomHeaderOption(num++, "守护型船员职业");
            AltruistOn = new CustomNumberOption(true, num++, "<color=#660000FF>殉道师</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MedicOn = new CustomNumberOption(true, num++, "<color=#006600FF>医生</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewSupportRoles = new CustomHeaderOption(num++, "支援型船员职业");
            EngineerOn = new CustomNumberOption(true, num++, "<color=#FFA60AFF>工程师</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MayorOn = new CustomNumberOption(true, num++, "<color=#704FA8FF>市长</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MediumOn = new CustomNumberOption(true, num++, "<color=#A680FFFF>通灵师</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SwapperOn = new CustomNumberOption(true, num++, "<color=#66E666FF>换票师</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TimeLordOn = new CustomNumberOption(true, num++, "<color=#0000FFFF>时间之主</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TransporterOn = new CustomNumberOption(true, num++, "<color=#00EEFFFF>传送者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);


            NeutralBenignRoles = new CustomHeaderOption(num++, "友善型独立职业");
            AmnesiacOn = new CustomNumberOption(true, num++, "<color=#80B2FFFF>失忆者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GuardianAngelOn = new CustomNumberOption(true, num++, "<color=#B3FFFFFF>守护天使</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SurvivorOn = new CustomNumberOption(true, num++, "<color=#FFE64DFF>投机主义者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            NeutralEvilRoles = new CustomHeaderOption(num++, "邪恶型独立职业");
            ExecutionerOn = new CustomNumberOption(true, num++, "<color=#8C4005FF>处刑者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JesterOn = new CustomNumberOption(true, num++, "<color=#FFBFCCFF>小丑</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            PhantomOn = new CustomNumberOption(true, num++, "<color=#662962FF>幻影</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            NeutralKillingRoles = new CustomHeaderOption(num++, "击杀型独立职业");
            ArsonistOn = new CustomNumberOption(true, num++, "<color=#FF4D00FF>纵火犯</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GlitchOn = new CustomNumberOption(true, num++, "<color=#00FF00FF>混沌</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorConcealingRoles = new CustomHeaderOption(num++, "干扰型伪装者职业");
            GrenadierOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>掷弹兵</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MorphlingOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>化形者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SwooperOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>隐形人</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorKillingRoles = new CustomHeaderOption(num++, "攻击型伪装者职业");
            PoisonerOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>绝命毒师</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TraitorOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>背叛者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            UnderdogOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>潜伏者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorSupportRoles = new CustomHeaderOption(num++, "Impostor Support Roles");
            BlackmailerOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>勒索者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JanitorOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>清洁工</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MinerOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>管道工</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            UndertakerOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>送葬者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewmateModifiers = new CustomHeaderOption(num++, "伪装者阵营及混沌职业以外附加效果");
            BaitOn = new CustomNumberOption(true, num++, "<color=#00B3B3FF>诱饵</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DiseasedOn = new CustomNumberOption(true, num++, "<color=#808080FF>病人</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TorchOn = new CustomNumberOption(true, num++, "<color=#FFFF99FF>火炬</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            GlobalModifiers = new CustomHeaderOption(num++, "全体职业附加效果");
            ButtonBarryOn = new CustomNumberOption(true, num++, "<color=#E600FFFF>按钮人</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DrunkOn = new CustomNumberOption(true, num++, "<color=#758000FF>醉鬼</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            FlashOn = new CustomNumberOption(true, num++, "<color=#FF8080FF>闪电侠</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GiantOn = new CustomNumberOption(true, num++, "<color=#FFB34DFF>巨人</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            LoversOn = new CustomNumberOption(true, num++, "<color=#FF66CCFF>恋人</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SleuthOn = new CustomNumberOption(true, num++, "<color=#803333FF>掘墓人</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TiebreakerOn = new CustomNumberOption(true, num++, "<color=#99E699FF>破平者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CustomGameSettings =
                new CustomHeaderOption(num++, "自定义游戏设置");
            ColourblindComms = new CustomToggleOption(num++, "通讯破坏时开启隐蔽效果", false);
            ImpostorSeeRoles = new CustomToggleOption(num++, "伪装者可见队友职业", false);
            DeadSeeRoles =
                new CustomToggleOption(num++, "灵魂可以看到玩家的职业/投票", false);
            MaxNeutralRoles =
                new CustomNumberOption(num++, "最大独立职业数量", 1f, 1f, 5f, 1f);
            VanillaGame = new CustomNumberOption(num++, "仅以船员与伪装者开始游戏概率", 0f, 0f, 100f, 5f,
                PercentFormat);
            InitialCooldowns =
                new CustomNumberOption(num++, "游戏开局冷却时间", 10, 10, 30, 2.5f, CooldownFormat);
            ParallelMedScans = new CustomToggleOption(num++, "可同时进行扫描任务（取消金水任务效果）", false);
            DisableLevels = new CustomToggleOption(num++, "隐藏等级图标", false);
            WhiteNameplates = new CustomToggleOption(num++, "隐藏玩家铭牌", false);

            TaskTrackingSettings =
                new CustomHeaderOption(num++, "任务数量显示设置");
            SeeTasksDuringRound = new CustomToggleOption(num++, "回合中显示任务数量", false);
            SeeTasksDuringMeeting = new CustomToggleOption(num++, "会议中显示任务数量", false);
            SeeTasksWhenDead = new CustomToggleOption(num++, "幽灵显示全员任务数量", true);

            Assassin = new CustomHeaderOption(num++, "<color=#FF0000FF>刺客能力</color>");
            NumberOfAssassins = new CustomNumberOption(num++, "可使用刺客能力的伪装者人数", 1, 0, 3, 1);
            AmneTurnAssassin = new CustomToggleOption(num++, , "失忆者可获得刺客能力", false);
            TraitorCanAssassin = new CustomToggleOption(num++, "背叛者可获得刺客能力", false);
            AssassinKills = new CustomNumberOption(num++, "刺客可猜测次数", 1, 1, 15, 1);
            AssassinMultiKill = new CustomToggleOption(num++, "每轮会议刺客可以多次使用猜测", false);
            AssassinCrewmateGuess = new CustomToggleOption(num++, "刺客可以猜测船员阵营职业", false);
            AssassinSnitchViaCrewmate = new CustomToggleOption(num++, "通过船员猜测刺杀告密者", false);
            AssassinGuessNeutralBenign = new CustomToggleOption(num++, "刺客可以猜测友善型独立阵营职业", false);
            AssassinGuessNeutralEvil = new CustomToggleOption(num++, "刺客可以猜测邪恶型独立阵营职业", false);
            AssassinGuessNeutralKilling = new CustomToggleOption(num++, "刺客可以猜测击杀型独立阵营职业", false);

            Haunter =
                new CustomHeaderOption(num++, "<color=#d3d3d3FF>冤魂</color>");
            HaunterTasksRemainingClicked =
                 new CustomNumberOption(num++, "当冤魂剩余多少任务时可被点击", 5, 1, 10, 1);
            HaunterTasksRemainingAlert =
                 new CustomNumberOption(num++, "当冤魂剩余多少任务时警告被揭示职业", 1, 1, 5, 1);
            HaunterRevealsNeutrals = new CustomToggleOption(num++, "冤魂可揭示独立阵营", false);
            HaunterCanBeClickedBy = new CustomStringOption(num++, "谁可以点击冤魂", new[] { "所有人", "非船员", "仅伪装者" });

            Investigator =
                new CustomHeaderOption(num++, "<color=#00B3B3FF>侦探</color>");
            FootprintSize = new CustomNumberOption(num++, "足迹大小", 4f, 1f, 10f, 1f);
            FootprintInterval =
                new CustomNumberOption(num++, "足迹间隔", 0.1f, 0.05f, 1f, 0.05f, CooldownFormat);
            FootprintDuration = new CustomNumberOption(num++, "足迹持续时间", 10f, 1f, 10f, 0.5f, CooldownFormat);
            AnonymousFootPrint = new CustomToggleOption(num++, "隐蔽效果足迹", false);
            VentFootprintVisible = new CustomToggleOption(num++, "可见通风口足迹", false);

            Mystic =
                new CustomHeaderOption(num++, "<color=#4D99E6FF>灵媒</color>");
            MysticArrowDuration =
                new CustomNumberOption(num++, "尸体箭头持续时间", 0.1f, 0f, 1f, 0.05f, CooldownFormat);

            Seer =
                new CustomHeaderOption(num++, "<color=#FFCC80FF>预言家</color>");
            SeerCooldown =
                new CustomNumberOption(num++, "预言技能冷却时间", 25f, 10f, 60f, 2.5f, CooldownFormat);
            CrewKillingRed =
                new CustomToggleOption(num++, "攻击型船员职业显示为红色", false);
            NeutBenignRed =
                new CustomToggleOption(num++, "友善型独立职业显示为红色", false);
            NeutEvilRed =
                new CustomToggleOption(num++, "敌对型独立职业显示为红色", false);
            NeutKillingRed =
                new CustomToggleOption(num++, "攻击型独立职业显示为红色", false);

            Snitch = new CustomHeaderOption(num++, "<color=#D4AF37FF>告密者</color>");
            SnitchOnLaunch =
                new CustomToggleOption(num++, "告密者开局时显示自己职位为告密者", false);
            SnitchSeesNeutrals = new CustomToggleOption(num++, "告密者揭示独立职业", false);
            SnitchTasksRemaining =
                 new CustomNumberOption(num++, "剩余多少任务时警告被揭示职业", 1, 1, 5, 1);
            SnitchSeesImpInMeeting = new CustomToggleOption(num++, "告密者在会议中显示被揭示职业", true);

            Tracker =
                new CustomHeaderOption(num++, "<color=#009900FF>追踪者</color>");
            UpdateInterval =
                new CustomNumberOption(num++, "箭头更新间隔", 5f, 0.5f, 15f, 0.5f, CooldownFormat);
            TrackCooldown =
                new CustomNumberOption(num++, "追踪技能冷却时间", 25f, 10f, 40f, 2.5f, CooldownFormat);
            ResetOnNewRound = new CustomToggleOption(num++, "追踪箭头在会议后重置", false);
            MaxTracks = new CustomNumberOption(num++, "每回合最大追踪人数", 5, 1, 15, 1);

            Sheriff =
                new CustomHeaderOption(num++, "<color=#FFFF00FF>警长</color>");
            SheriffKillOther =
                new CustomToggleOption(num++, "警长误杀船员时目标也死亡", false);
            SheriffKillsJester =
                new CustomToggleOption(num++, "警长可击杀小丑", false);
            SheriffKillsGlitch =
                new CustomToggleOption(num++, "警长可击杀混沌", false);
            SheriffKillsExecutioner =
                new CustomToggleOption(num++, "警长可击杀处刑人", false);
            SheriffKillsArsonist =
                new CustomToggleOption(num++, "警长可击杀纵火犯", false);
            SheriffKillCd =
                new CustomNumberOption(num++, "警长击杀冷却时间", 25f, 10f, 40f, 2.5f, CooldownFormat);
            SheriffBodyReport = new CustomToggleOption(num++, "警长可以自刀自报");

            Veteran =
                new CustomHeaderOption(num++, "<color=#998040FF>老兵</color>");
            KilledOnAlert =
                new CustomToggleOption(num++, "可在警戒时被击杀", false);
            AlertCooldown =
                new CustomNumberOption(num++, "警戒技能冷却时间", 25, 10, 60, 2.5f, CooldownFormat);
            AlertDuration =
                new CustomNumberOption(num++, "警戒技能持续时间", 10, 5, 15, 1f, CooldownFormat);
            MaxAlerts = new CustomNumberOption(num++, "最大警戒技能次数", 5, 1, 15, 1);

            Vigilante = new CustomHeaderOption(num++, "<color=#FFFF99FF>侠客</color>");
            VigilanteKills = new CustomNumberOption(num++, "侠客最大猜测次数", 1, 1, 15, 1);
            VigilanteMultiKill = new CustomToggleOption(num++, "每轮会议侠客可以多次使用猜测", false);
            VigilanteGuessNeutralBenign = new CustomToggleOption(num++, "侠客可以猜测友善型独立阵营职业", false);
            VigilanteGuessNeutralEvil = new CustomToggleOption(num++, "侠客可以猜测邪恶型独立阵营职业", false);
            VigilanteGuessNeutralKilling = new CustomToggleOption(num++, "侠客可以猜测击杀型独立阵营职业", false);

            Altruist = new CustomHeaderOption(num++, "<color=#660000FF>殉道师</color>");
            ReviveDuration =
                new CustomNumberOption(num++, "殉道者复活时间", 10, 1, 30, 1f, CooldownFormat);
            AltruistTargetBody =
                new CustomToggleOption(num++, "目标在开始复活时目标尸体消失", false);

            Medic =
                new CustomHeaderOption(num++, "<color=#006600FF>医生</color>");
            ShowShielded =
                new CustomStringOption(num++, "谁可以看见护盾效果",
                    new[] { "仅自己", "医生", "被保护人+医生", "所有人" });
            WhoGetsNotification =
                new CustomStringOption(num++, "谁可以看到被击杀尝试",
                    new[] { "医生", "被保护人", "所有人", "没有人" });
            ShieldBreaks = new CustomToggleOption(num++, "挡刀一次护盾破碎", false);
            MedicReportSwitch = new CustomToggleOption(num++, "显示尸检报告");
            MedicReportNameDuration =
                new CustomNumberOption(num++, "时间内报告会有凶手名字", 0, 0, 60, 2.5f,
                    CooldownFormat);
            MedicReportColorDuration =
                new CustomNumberOption(num++, "时间内报告会有凶手颜色类型", 15, 0, 120, 2.5f,
                    CooldownFormat);

            Engineer =
                new CustomHeaderOption(num++, "<color=#FFA60AFF>工程师</color>");
            EngineerPer =
                new CustomStringOption(num++, "工程师修复次数", new[] { "每回合一次", "每游戏一次" });

            Mayor =
                new CustomHeaderOption(num++, "<color=#704FA8FF>市长</color>");
            MayorVoteBank =
                new CustomNumberOption(num++, "初始市长票数", 1, 1, 5, 1);
            MayorAnonymous =
                new CustomToggleOption(num++, "市长匿名投票", false);

            Medium =
                new CustomHeaderOption(num++, "<color=#A680FFFF>通灵师</color>");
            MediateCooldown =
                new CustomNumberOption(num++, "通灵冷却", 10f, 1f, 15f, 1f, CooldownFormat);
            ShowMediatePlayer =
                new CustomToggleOption(num++, "显示通灵目标的外观", true);
            ShowMediumToDead =
                new CustomToggleOption(num++, "将通灵师展示给通灵目标", true);
            DeadRevealed =
                new CustomStringOption(num++, "通灵透露的信息", new[] { "Oldest Dead", "Newest Dead", "All Dead" });

            Swapper =
                new CustomHeaderOption(num++, "<color=#66E666FF>换票师</color>");
            SwapperButton =
                new CustomToggleOption(num++, "换票师可以召开紧急会议", true);

            TimeLord =
                new CustomHeaderOption(num++, "<color=#0000FFFF>时间之主</color>");
            RewindRevive = new CustomToggleOption(num++, "回溯时可复活死者", false);
            RewindDuration = new CustomNumberOption(num++, "回溯时间", 2f, 2f, 5f, 0.5f, CooldownFormat);
            RewindCooldown = new CustomNumberOption(num++, "回溯技能冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RewindMaxUses =
                 new CustomNumberOption(num++, "回溯技能使用次数", 5, 1, 15, 1);
            TimeLordVitals =
                new CustomToggleOption(num++, "时间之主可使用心跳监测器", false);

            Transporter =
                new CustomHeaderOption(num++, "<color=#00EEFFFF>传送师</color>");
            TransportCooldown =
                new CustomNumberOption(num++, "传送冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            TransportMaxUses =
                new CustomNumberOption(num++, "最多传送次数", 5, 1, 15, 1);
            TransporterVitals =
                new CustomToggleOption(num++, "传送师可使用心跳监测器", false);

            Amnesiac = new CustomHeaderOption(num++, "<color=#80B2FFFF>失忆者</color>");
            RememberArrows =
                new CustomToggleOption(num++, "失忆者显示尸体箭头", false);
            RememberArrowDelay =
                new CustomNumberOption(num++, "有尸体后箭出现时间", 5f, 0f, 15f, 1f, CooldownFormat);

            GuardianAngel =
                new CustomHeaderOption(num++, "<color=#B3FFFFFF>守护天使</color>");
            ProtectCd =
                new CustomNumberOption(num++, "守护冷却", 25, 10, 60, 2.5f, CooldownFormat);
            ProtectDuration =
                new CustomNumberOption(num++, "守护持续时间", 10, 5, 15, 1f, CooldownFormat);
            ProtectKCReset =
                new CustomNumberOption(num++, "受保护时被杀死时凶手冷却重置", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxProtects =
                new CustomNumberOption(num++, "最大保护次数", 5, 1, 15, 1);
            ShowProtect =
                new CustomStringOption(num++, "展示被保护玩家",
                    new[] { "自己", "守护天使", "自己+守护天使", "所有人" });
            GaOnTargetDeath = new CustomStringOption(num++, "守护天使在目标上死亡",
                new[] { "船员", "失忆者", "投机主义者", "小丑" });

            Survivor =
                new CustomHeaderOption(num++, "<color=#FFE64DFF>投机主义者</color>");
            VestCd =
                new CustomNumberOption(num++, "背心冷却", 25, 10, 60, 2.5f, CooldownFormat);
            VestDuration =
                new CustomNumberOption(num++, "背心持续时间", 10, 5, 15, 1f, CooldownFormat);
            VestKCReset =
                new CustomNumberOption(num++, "被攻击时凶手冷却重置", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxVests =
                new CustomNumberOption(num++, "最多使用背心次数", 5, 1, 15, 1);

            Executioner =
                new CustomHeaderOption(num++, "<color=#8C4005FF>处刑者</color>");
            OnTargetDead = new CustomStringOption(num++, "目标死亡后处刑人新职业",
                new[] { "船员", "失忆者", "投机主义者", "小丑" });
            ExecutionerButton =
                new CustomToggleOption(num++, "处刑者可以召开紧急会议", true);

            Jester =
                new CustomHeaderOption(num++, "<color=#FFBFCCFF>小丑</color>");
            JesterButton =
                new CustomToggleOption(num++, "小丑可以召开紧急会议", true);
            JesterVent =
                new CustomToggleOption(num++, "小丑可以跳通风管道", false);

            Phantom =
                new CustomHeaderOption(num++, "<color=#662962FF>幻影</color>");
            PhantomTasksRemaining =
                 new CustomNumberOption(num++, "幻影剩余多少任务时可被点击", 5, 1, 10, 1);

            Arsonist = new CustomHeaderOption(num++, "<color=#FF4D00FF>纵火犯</color>");
            DouseCooldown =
                new CustomNumberOption(num++, "浇油冷却", 25f, 10f, 40f, 2.5f, CooldownFormat);
            ArsonistGameEnd = new CustomToggleOption(num++, "当纵火犯存活时游戏不会结束", false);

            TheGlitch =
                new CustomHeaderOption(num++, "<color=#00FF00FF>混沌</color>");
            MimicCooldownOption = new CustomNumberOption(num++, "模仿冷却", 25f, 10f, 120f, 2.5f, CooldownFormat);
            MimicDurationOption = new CustomNumberOption(num++, "模仿持续时间", 10f, 1f, 30f, 1f, CooldownFormat);
            HackCooldownOption = new CustomNumberOption(num++, "黑进冷区", 25f, 10f, 120f, 2.5f, CooldownFormat);
            HackDurationOption = new CustomNumberOption(num++, "黑进持续时间", 10f, 1f, 30f, 1f, CooldownFormat);
            GlitchKillCooldownOption =
                new CustomNumberOption(num++, "混沌击杀冷却", 25f, 10f, 120f, 2.5f, CooldownFormat);
            GlitchHackDistanceOption =
                new CustomStringOption(num++, "混沌黑进距离", new[] { "短", "中", "长" });
            GlitchVent =
                new CustomToggleOption(num++, "混沌可使用通风管道", false);

            Grenadier =
                new CustomHeaderOption(num++, "<color=#FF0000FF>掷弹兵</color>");
            GrenadeCooldown =
                new CustomNumberOption(num++, "闪光弹技能冷却时间", 25, 10, 40, 2.5f, CooldownFormat);
            GrenadeDuration =
                new CustomNumberOption(num++, "闪光弹技能持续时间", 10, 5, 15, 1f, CooldownFormat);
            FlashRadius =
                new CustomNumberOption(num++, "闪光弹技能范围", 1f, 0.25f, 5f, 0.25f, MultiplierFormat);
            GrenadierVent =
                new CustomToggleOption(num++, "掷弹兵可以使用通风口", false);

            Morphling =
                new CustomHeaderOption(num++, "<color=#FF0000FF>化形者</color>");
            MorphlingCooldown =
                new CustomNumberOption(num++, "化形冷区", 25, 10, 40, 2.5f, CooldownFormat);
            MorphlingDuration =
                new CustomNumberOption(num++, "化形持续时间", 10, 5, 15, 1f, CooldownFormat);
            MorphlingVent =
                new CustomToggleOption(num++, "可以使用通风管道", false);

            Swooper = new CustomHeaderOption(num++, "<color=#FF0000FF>隐身人</color>");

            SwoopCooldown =
                new CustomNumberOption(num++, "隐身冷却", 25, 10, 40, 2.5f, CooldownFormat);
            SwoopDuration =
                new CustomNumberOption(num++, "隐身持续时间", 10, 5, 15, 1f, CooldownFormat);
            SwooperVent =
                new CustomToggleOption(num++, "可以使用通风管道", false);

            Poisoner =
                new CustomHeaderOption(num++, "<color=#FF0000FF>绝命毒师</color>");
            PoisonCooldown =
                new CustomNumberOption(num++, "下毒技能冷却时间", 25, 10, 40, 2.5f, CooldownFormat);
            PoisonDuration =
                new CustomNumberOption(num++, "下毒延迟击杀时间", 5, 1, 15, 1f, CooldownFormat);
            PoisonerVent =
                new CustomToggleOption(num++, "绝命毒师可使用通风口", false);

            Traitor = new CustomHeaderOption(num++, "<color=#FF0000FF>背叛者</color>");
            LatestSpawn = new CustomNumberOption(num++, "背叛者出现时最少存活玩家数", 5, 2, 15, 1);
            GlitchStopsTraitor =
                new CustomToggleOption(num++, "混沌存活时背叛者不会出现", false);

            Underdog = new CustomHeaderOption(num++, "<color=#FF0000FF>潜伏者</color>");
            UnderdogKillBonus = new CustomNumberOption(num++, "击杀冷却时间加减值", 5, 2.5f, 30, 2.5f, CooldownFormat);
            UnderdogIncreasedKC = new CustomToggleOption(num++, "队友存活时击杀冷却时间增加", true);

            Blackmailer = new CustomHeaderOption(num++, "<color=#FF0000FF>勒索者</color>");
            BlackmailCooldown =
                new CustomNumberOption(num++, "初始勒索冷却时间", 10, 1, 15, 1f, CooldownFormat);

            Miner = new CustomHeaderOption(num++, "<color=#FF0000FF>管道工</color>");
            MineCooldown =
                new CustomNumberOption(num++, "布置管道冷却", 25, 10, 40, 2.5f, CooldownFormat);

            Undertaker = new CustomHeaderOption(num++, "<color=#FF0000FF>送葬者</color>");
            DragCooldown = new CustomNumberOption(num++, "拖尸技能冷却时间", 25, 10, 40, 2.5f, CooldownFormat);
            UndertakerVent =
                new CustomToggleOption(num++, "送葬者可以使用通风口", false);
            UndertakerVentWithBody =
                new CustomToggleOption(num++, "送葬者可以在拖动时使用通风口", false);

            Lovers =
                new CustomHeaderOption(num++, "<color=#FF66CCFF>恋人</color>");
            BothLoversDie = new CustomToggleOption(num++, "恋人同死");
            LovingImpPercent = new CustomNumberOption(num++, "伪装者恋人概率", 20f, 0f, 100f, 10f,
                PercentFormat);
            NeutralLovers = new CustomToggleOption(num++, "独立职业可以成为恋人");
        }
    }
}