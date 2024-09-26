using EnemyReleveler.Interfaces;
using EnemyReleveler.Models;
using System.Collections.Generic;

namespace EnemyReleveler.LevelRanges
{
    /// <summary>
    /// Uses ranges from https://github.com/Graca98/Skyrim-Wigo-Releveler-Graco/blob/main/EnemyReleveler/enemy_rules_synthesis.json
    /// </summary>
    public class VanillaRanges : ILevelRanges
    {
        private readonly Dictionary<string, LevelRange> levels = new Dictionary<string, LevelRange>()
        {
            { "BanditFaction", new LevelRange(1, 28) },
            { "DraugrFaction", new LevelRange(1, 45) },
            { "DLC2CultistFaction", new LevelRange(1, 46) },
            { "DragonPriestFaction", new LevelRange(50, 60) },
            { "BearFaction", new LevelRange(12, 20) },
            { "ChaurusFaction", new LevelRange(1, 50) },
            { "DwarvenAutomatonFaction", new LevelRange(5, 38) },
            { "FalmerFaction", new LevelRange(1, 54) },
            { "DaedraFaction", new LevelRange(5, 65) },
            { "DogFaction", new LevelRange(2, 25) },
            { "TrollFaction", new LevelRange(14, 22) },
            { "SpiderFaction", new LevelRange(1, 17) },
            { "DLC1UndeadGuardianFaction", new LevelRange(13, 43) },
            { "HagravenFaction", new LevelRange(4, 20) },
            { "WolfFaction", new LevelRange(1, 6) },
            { "GiantFaction", new LevelRange(30, 90) },
            { "IceWraithFaction", new LevelRange(1, 9) },
            { "MammothFaction", new LevelRange(1, 38) },
            { "DragonFaction", new LevelRange(10, 100) },
            { "SabreCatFaction", new LevelRange(6, 12) },
            { "SkeeverFaction", new LevelRange(1, 7) },
            { "SkeletonFaction", new LevelRange(1, 80) },
            { "SlaughterfishFaction", new LevelRange(0, 1) },
            { "SprigganFaction", new LevelRange(1, 30) },
            { "WerewolfFaction", new LevelRange(1, 42) },
            { "WispFaction", new LevelRange(1, 28) },
            { "ForswornFaction", new LevelRange(1, 51) },
            { "WarlockFaction", new LevelRange(1, 50) },
            { "VampireFaction", new LevelRange(1, 65) },
            { "DLC1VampireFaction", new LevelRange(1, 60) },
            { "ThalmorFaction", new LevelRange(4, 50) },
            { "OrcFriendFaction", new LevelRange(1, 30) },
            { "MS08AlikrFaction", new LevelRange(1, 44) },
            { "DLC1HunterFaction", new LevelRange(5, 50) },
            { "MS07BanditFaction", new LevelRange(1, 25) },
            { "DLC2MoragTongFaction", new LevelRange(1, 25) },
            { "DLC2RieklingFaction", new LevelRange(6, 90) },
            { "DLC2RavenRockGuardFaction", new LevelRange(20, 50) },
            { "DLC2AshSpawnFaction", new LevelRange(13, 70) },
            { "WEBountyHunter", new LevelRange(1, 28) },
            { "HorkerFaction", new LevelRange(3, 25) },
            { "VigilantOfStendarrFaction", new LevelRange(5, 30) },
            { "SilverHandFaction", new LevelRange(1, 28) },
            { "CWImperialFaction", new LevelRange(1, 10) },
            { "CWSonsFaction", new LevelRange(1, 10) },
            { "IsGuardFaction", new LevelRange(1, 50) },
            { "HunterFaction", new LevelRange(5, 15) },
            { "DremoraFaction", new LevelRange(6, 46) },
            { "DLC2BenthicLurkerFaction", new LevelRange(24, 54) },
            { "DLC2SeekerFaction", new LevelRange(21, 42) },
            { "DLC2NetchFaction", new LevelRange(25, 40) },
            { "DLC2TribalWerebearFaction", new LevelRange(17, 17) },
            { "PenitusOculatusFaction", new LevelRange(1, 100) },
            { "DA13AfflictedFaction", new LevelRange(1, 40) },
            { "DA16OrcAmbushFaction", new LevelRange(1, 25) },
            { "dunKilkreathFaction", new LevelRange(1, 100) },
            { "KhajiitCaravanFaction", new LevelRange(4, 30) }
        };

        public Dictionary<string, LevelRange> GetLevelRanges()
        {
            return levels;
        }
    }    
}
