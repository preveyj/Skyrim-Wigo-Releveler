using EnemyReleveler.Interfaces;
using EnemyReleveler.Models;
using System.Collections.Generic;

namespace EnemyReleveler.DefaultValues
{
    /// <summary>
    /// Holds default level ranges by enemy list.
    /// </summary>
    /// <remarks>
    /// Uses ranges from https://www.nexusmods.com/skyrimspecialedition/mods/32211
    /// </remarks>
    public class DefaultLevelRanges : ILevelRanges
    {
        //defaults from the list in https://www.nexusmods.com/skyrimspecialedition/mods/32211
        
        //todo: get a list of remaining faction names
        private readonly Dictionary<string, LevelRange> levels = new Dictionary<string, LevelRange>() {
            { "BanditFaction", new LevelRange(4, 16) },
            { "DraugrFaction", new LevelRange(16, 45) },
            { "DLC2CultistFaction", new LevelRange(18, 46) },
            { "DragonPriestFaction", new LevelRange(70, 90) },
            { "BearFaction", new LevelRange(14, 22) },
            { "ChaurusFaction", new LevelRange(16, 60) },
            { "DwarvenAutomatonFaction", new LevelRange(25, 78) },
            { "FalmerFaction", new LevelRange(30, 65) },
            { "DaedraFaction", new LevelRange(5, 65) },
            { "DogFaction", new LevelRange(4, 12) },
            { "TrollFaction", new LevelRange(20, 28) },
            { "SpiderFaction", new LevelRange(1, 6) },
            { "DLC1UndeadGuardianFaction", new LevelRange(40, 64) }, //gargoyles?
            { "HagravenFaction", new LevelRange(24, 50) },
            { "WolfFaction", new LevelRange(2, 6) },
            { "GiantFaction", new LevelRange(60, 90) },
            { "IceWraithFaction", new LevelRange(12, 20) },
            { "MammothFaction", new LevelRange(1, 50) },
            { "DragonFaction", new LevelRange(40, 100) },
            { "SabreCatFaction", new LevelRange(10, 18) },
            { "SkeeverFaction", new LevelRange(1,3) },
            { "SkeletonFaction", new LevelRange(18, 80) },
            { "SlaughterfishFaction", new LevelRange(0, 1) },
            { "SprigganFaction", new LevelRange(8, 21) },
            { "WerewolfFaction", new LevelRange(30, 58) },
            { "WispFaction", new LevelRange(1, 28) },
            { "ForswornFaction", new LevelRange(8, 18) },
            { "WarlockFaction", new LevelRange(24, 46) },
            { "VampireFaction", new LevelRange(36, 64) },
            { "DLC1VampireFaction", new LevelRange(42, 72) },
            { "ThalmorFaction", new LevelRange(20, 45) },
            { "OrcFriendFaction", new LevelRange(6, 28) },
            { "MS08AlikrFaction", new LevelRange(14, 22) },
            { "DLC1HunterFaction", new LevelRange(22, 50) }, //Dawnguard?
            { "MS07BanditFaction", new LevelRange(12, 25) },
            { "DLC2MoragTongFaction", new LevelRange(26, 36) },
            { "DLC2RieklingFaction", new LevelRange(14, 90) },
            { "DLC2RavenRockGuardFaction", new LevelRange(25, 35) },
            { "DLC2AshSpawnFaction", new LevelRange(32, 60) },
            { "WEBountyHunter", new LevelRange(14, 30) },
            { "HorkerFaction", new LevelRange(8, 16) },
            { "VigilantOfStendarrFaction", new LevelRange(18, 27) },
            { "SilverHandFaction", new LevelRange(11, 23) },
            { "CWImperialFaction", new LevelRange(10, 30) },
            { "CWSonsFaction", new LevelRange(10, 30) },
            { "IsGuardFaction", new LevelRange(10, 25) }
        };

        public Dictionary<string, LevelRange> GetLevelRanges()
        {
            return levels;
        }
    }
}
