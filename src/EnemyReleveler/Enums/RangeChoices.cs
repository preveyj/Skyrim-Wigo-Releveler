namespace EnemyReleveler.Enums
{
    /// <summary>
    /// Used to select which level range set to use
    /// </summary>
    /// <remarks>
    /// To implement your own level ranges and add to this list, 
    ///     create a class in LevelRanges, 
    ///     implement <see cref="ILevelRanges"/>, 
    ///     and add a name here before Custom.
    /// </remarks>
    public enum RangeChoices
    {
        Default,
        Graca98,
        //insert a name for your level range set here
        Custom,
        Vanilla
            
        //,Invalid //for manual only
    }
}
