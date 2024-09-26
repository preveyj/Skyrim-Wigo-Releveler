using EnemyReleveler.Enums;

namespace EnemyReleveler.Interfaces
{
    /// <summary>
    /// Get a <see cref="ILevelRanges"/> collection from the given <see cref="RangeChoices"/>
    /// </summary>
    public interface ILevelRangeSelector
    {
        public ILevelRanges GetLevelRangeBySelection(RangeChoices choice);
    }
}
