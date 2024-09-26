using EnemyReleveler.Models;
using System.Collections.Generic;

namespace EnemyReleveler.Interfaces
{
    /// <summary>
    /// An interface for holding a dictionary of level ranges by faction name.
    /// </summary>
    public interface ILevelRanges
    {
        Dictionary<string, LevelRange> GetLevelRanges();
    }
}
