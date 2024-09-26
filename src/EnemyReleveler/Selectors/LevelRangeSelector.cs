using EnemyReleveler.DefaultValues;
using EnemyReleveler.Enums;
using EnemyReleveler.Interfaces;
using EnemyReleveler.LevelRanges;
using System.Collections.Generic;

namespace EnemyReleveler.Selectors
{
    public class LevelRangeSelector : ILevelRangeSelector
    {
        private readonly Dictionary<RangeChoices, ILevelRanges> _selectableRanges = new Dictionary<RangeChoices, ILevelRanges>
        {
            { RangeChoices.Default, new DefaultLevelRanges() },
            { RangeChoices.Graca98, new Graca98Ranges() },
            { RangeChoices.Custom, new CustomLevelRanges() },            
            { RangeChoices.Vanilla, new VanillaRanges() },
            
            //,{RangeChoices.Invalid, new InvalidRange() }
        };    

        public ILevelRanges GetLevelRangeBySelection(RangeChoices choice)
        {
            return _selectableRanges[choice];
        }
    }
}
