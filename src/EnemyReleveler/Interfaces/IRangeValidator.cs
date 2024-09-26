using EnemyReleveler.Enums;
using EnemyReleveler.Models;
using System;
using System.Collections.Generic;

namespace EnemyReleveler.Interfaces
{
    public interface IRangeValidator
    {
        /// <summary>
        /// Validates the given level range list.
        /// </summary>
        /// <param name="range"></param>
        bool ValidateList(Dictionary<string, LevelRange> range);
    }
}
