using EnemyReleveler.Interfaces;
using EnemyReleveler.Models;
using System;
using System.Collections.Generic;

namespace EnemyReleveler.Validators
{
    public class RangeValidator : IRangeValidator
    {
        public bool ValidateList(Dictionary<string, LevelRange> ranges)
        {
            bool listIsValid = true;

            if (ranges == null)
            {
                Console.Error.WriteLine("Level range is null!");
                return false;
            }

            foreach (var range in ranges)
            {
                if (range.Value.MinLevel < 0 || range.Value.MaxLevel < 0)
                {
                    Console.Error.WriteLine($"Faction: {range.Key} -> Levels must be positive!");
                    listIsValid = false;
                }

                if (range.Value.MinLevel > range.Value.MaxLevel)
                {
                    Console.Error.WriteLine($"Faction: {range.Key} -> Minimum level must be less than or equal to maximum level!");
                    listIsValid = false;
                }
            }

            return listIsValid;
        }
    }
}
