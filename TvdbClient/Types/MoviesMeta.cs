using System.Runtime.Serialization;

namespace Tvdb.Types;

/// <summary>
/// MetaData for <see cref="Models.MovieBaseRecord"/>
/// </summary>
public enum MoviesMeta
{
    /// <summary>
    /// Include <see cref="Models.MovieExtendedRecord.Translations"/>
    /// </summary>
    [EnumMember(Value = @"translations")]
    Translations = 0,
}