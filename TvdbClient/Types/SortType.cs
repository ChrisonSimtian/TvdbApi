using System.Runtime.Serialization;

namespace Tvdb.Types;

/// <summary>
/// Sortation Direction
/// </summary>
public enum SortType
{
    /// <summary>
    /// Ascending
    /// </summary>
    [EnumMember(Value = @"asc")]
    Ascending = 0,

    /// <summary>
    /// Descending
    /// </summary>
    [EnumMember(Value = @"desc")]
    Descending = 1,
}