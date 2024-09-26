using EnemyReleveler.Interfaces;
using EnemyReleveler.Models;
using System.Collections.Generic;

namespace EnemyReleveler.LevelRanges
{
    /// <summary>
    /// Uses ranges from https://github.com/Graca98/Skyrim-Wigo-Releveler-Graco/blob/main/EnemyReleveler/enemy_rules_synthesis.json
    /// </summary>
    public class Graca98Ranges : ILevelRanges
    {
        private readonly Dictionary<string, LevelRange> levels = new Dictionary<string, LevelRange>()
        {
            { "BanditFaction", new LevelRange( 10, 100) },
            { "DraugrFaction", new LevelRange( 16, 120) },
            { "DLC2CultistFaction", new LevelRange( 18, 110) },
            { "DragonPriestFaction", new LevelRange( 70, 250) },
            { "BearFaction", new LevelRange( 14, 22) },
            { "ChaurusFaction", new LevelRange( 16, 60) },
            { "DwarvenAutomatonFaction", new LevelRange( 25, 100) },
            { "FalmerFaction", new LevelRange( 30, 120) },
            { "DaedraFaction", new LevelRange( 5, 65) },
            { "DogFaction", new LevelRange( 4, 12) },
            { "TrollFaction", new LevelRange( 20, 50) },
            { "SpiderFaction", new LevelRange( 1, 20) },
            { "DLC1UndeadGuardianFaction", new LevelRange( 40, 120) },
            { "HagravenFaction", new LevelRange( 24, 80) },
            { "WolfFaction", new LevelRange( 2, 12) },
            { "GiantFaction", new LevelRange( 60, 300) },
            { "IceWraithFaction", new LevelRange( 12, 20) },
            { "MammothFaction", new LevelRange( 1, 200) },
            { "DragonFaction", new LevelRange( 60, 350) },
            { "SabreCatFaction", new LevelRange( 10, 18) },
            { "SkeeverFaction", new LevelRange( 1, 3) },
            { "SkeletonFaction", new LevelRange( 18, 80) },
            { "SlaughterfishFaction", new LevelRange( 0, 1) },
            { "SprigganFaction", new LevelRange( 8, 21) },
            { "WerewolfFaction", new LevelRange( 30, 78) },
            { "WispFaction", new LevelRange( 1, 28) },
            { "ForswornFaction", new LevelRange( 15, 100) },
            { "WarlockFaction", new LevelRange( 24, 120) },
            { "VampireFaction", new LevelRange( 45, 140) },
            { "DLC1VampireFaction", new LevelRange( 62, 160) },
            { "ThalmorFaction", new LevelRange( 20, 70) },
            { "OrcFriendFaction", new LevelRange( 6, 38) },
            { "MS08AlikrFaction", new LevelRange( 14, 54) },
            { "DLC1HunterFaction", new LevelRange( 22, 70) },
            { "MS07BanditFaction", new LevelRange( 12, 125) },
            { "DLC2MoragTongFaction", new LevelRange( 26, 66) },
            { "DLC2RieklingFaction", new LevelRange( 14, 140) },
            { "DLC2RavenRockGuardFaction", new LevelRange( 25, 65) },
            { "DLC2AshSpawnFaction", new LevelRange( 32, 80) },
            { "WEBountyHunter", new LevelRange( 14, 60) },
            { "HorkerFaction", new LevelRange( 8, 16) },
            { "VigilantOfStendarrFaction", new LevelRange( 18, 77) },
            { "SilverHandFaction", new LevelRange( 11, 123) },
            { "CWImperialFaction", new LevelRange( 10, 60) },
            { "CWSonsFaction", new LevelRange( 10, 60) },
            { "IsGuardFaction", new LevelRange( 60, 80) },
            { "HunterFaction", new LevelRange( 12, 22) },
            { "DremoraFaction", new LevelRange( 28, 80) },
            { "DLC2BenthicLurkerFaction", new LevelRange( 35, 75) },
            { "DLC2SeekerFaction", new LevelRange( 25, 65) },
            { "DLC2NetchFaction", new LevelRange( 20, 66) },
            { "DLC2TribalWerebearFaction", new LevelRange( 36, 66) },
            { "PenitusOculatusFaction", new LevelRange( 25, 65) },
            { "DA13AfflictedFaction", new LevelRange( 5, 65) },
            { "DA16OrcAmbushFaction", new LevelRange( 22, 42) },
            { "dunKilkreathFaction", new LevelRange( 15, 65) },
            { "KhajiitCaravanFaction", new LevelRange( 9, 65) }
        };

        public Dictionary<string, LevelRange> GetLevelRanges()
        {
            return levels;
        }
    }
}
