using System.Runtime.Serialization;

namespace Tvdb.Types;

/// <summary>
/// Sortation for <see cref="Models.SeriesBaseRecord">
/// </summary>
public enum SeriesSort
{
    /// <summary>
    /// Sort by <see cref="Models.SeriesBaseRecord.Score"/>"/>
    /// </summary>
    [EnumMember(Value = @"score")]
    Score = 0,

    /// <summary>
    /// Sort by <see cref="Models.SeriesBaseRecord.FirstAired"/>"/>
    /// </summary>
    [EnumMember(Value = @"firstAired")]
    FirstAired = 1,

    /// <summary>
    /// Sort by <see cref="Models.SeriesBaseRecord.LastAired"/>"/>
    /// </summary>
    [EnumMember(Value = @"lastAired")]
    LastAired = 2,

    /// <summary>
    /// Sort by <see cref="Models.SeriesBaseRecord.Name"/>"/>
    /// </summary>
    [EnumMember(Value = @"name")]
    Name = 3,
}