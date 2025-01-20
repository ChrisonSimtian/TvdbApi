using System.Runtime.Serialization;

namespace Tvdb.Types;

/// <summary>
/// Sortation for <see cref="Models.MovieBaseRecord"/>
/// </summary>
public enum MovieSort
{
    /// <summary>
    /// Sort by <see cref="Models.MovieBaseRecord.Score"/>"/>
    /// </summary>
    [EnumMember(Value = @"score")]
    Score = 0,

    /// <summary>
    /// Sort by Air Date
    /// </summary>
    [EnumMember(Value = @"firstAired")]
    FirstAired = 1,

    /// <summary>
    /// Sort by <see cref="Models.MovieBaseRecord.Name"/>"/>
    /// </summary>
    [EnumMember(Value = @"name")]
    Name = 2,
}