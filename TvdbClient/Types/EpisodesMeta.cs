using System.Runtime.Serialization;
namespace Tvdb.Types;

/// <summary>
/// MetaData for <see cref="Models.EpisodeBaseRecord"/>
/// </summary>
public enum EpisodesMeta
{
    /// <summary>
    /// Include <see cref="Models.EpisodeExtendedRecord.Translations"/>
    /// </summary>
    [EnumMember(Value = @"translations")]
    Translations = 0,
}