using EnemyReleveler.Interfaces;
using EnemyReleveler.Models;
using System.Collections.Generic;

namespace EnemyReleveler.LevelRanges
{
    /// <summary>
    /// A non-valid level range, for testing only.
    /// </summary>
    public class InvalidRange : ILevelRanges
    {
        public Dictionary<string, LevelRange> GetLevelRanges()
        {
            return new Dictionary<string, LevelRange>() 
            {
                {"invalid1", new LevelRange(-1, -1) },
                {"invalid2", new LevelRange(-1, 0) },
                {"invalid3", new LevelRange(0, -1) },
                {"invalid4", new LevelRange(4, 3) }
            };
        }
    }
}
