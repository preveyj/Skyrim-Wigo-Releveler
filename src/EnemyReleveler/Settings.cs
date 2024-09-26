using EnemyReleveler.DefaultValues;
using EnemyReleveler.Enums;
using EnemyReleveler.Models;
using Mutagen.Bethesda.Synthesis.Settings;
using System.Collections.Generic;

namespace EnemyReleveler
{
    public class Settings
    {
        [SynthesisSettingName("Use Global Offset")]
        [SynthesisTooltip("Adds this value to all level ranges")]
        public int GlobalOffset { get; set; } = 0;

        [SynthesisSettingName("Print Debug Output")]
        public bool PrintDebugOutput { get; set; } = false;

        public RangeChoices RangeChoices { get; set; }

        private Dictionary<string, LevelRange> _customLevelRanges = new CustomLevelRanges().GetLevelRanges();

        [SynthesisSettingName("Custom Level Ranges - used only if \"Custom\" is selected in Range Choices.")]
        public Dictionary<string, LevelRange> CustomLevelRanges { get { return _customLevelRanges; } set { _customLevelRanges = value; } }

        [SynthesisTooltip("Wether to clamp max level to the new range.  Without this setting, some NPCs may get strangehly high max levels.")]
        public bool ClampMaxLevel { get; set; }
    }
}
