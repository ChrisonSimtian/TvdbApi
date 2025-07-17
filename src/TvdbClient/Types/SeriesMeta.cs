using System.Runtime.Serialization;

namespace Tvdb.Types;

/// <summary>
/// MetaData for <see cref="Models.SeriesBaseRecord"/> to include
/// </summary>
public enum SeriesMeta
{
    /// <summary>
    /// Include <see cref="Models.SeriesExtendedRecord.Translations"/>
    /// </summary>
    [EnumMember(Value = @"translations")]
    Translations = 0,

    /// <summary>
    /// Include Episodes on <see cref="Models.SeriesExtendedRecord.Seasons"/>
    /// </summary>
    [EnumMember(Value = @"episodes")]
    Episodes = 1,
}