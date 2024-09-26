using System.ComponentModel.DataAnnotations;

namespace EnemyReleveler.Models
{
    public class LevelRange
    {
        public LevelRange() { }
        public LevelRange(int minLevel, int maxLevel)
        {
            MinLevel = minLevel;
            MaxLevel = maxLevel;
        }

        [Range(0, 999)]
        public int MinLevel { get; set; }
        [Range(0, 999)]
        public int MaxLevel { get; set; }
    }
}
