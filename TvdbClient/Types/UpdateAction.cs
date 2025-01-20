using System.Runtime.Serialization;

namespace Tvdb.Types;

/// <summary>
/// The action to perform on an update.
/// </summary>
public enum UpdateAction
{
    /// <summary>
    /// Got Deleted
    /// </summary>
    [EnumMember(Value = @"delete")]
    Delete = 0,

    /// <summary>
    /// Got Updated
    /// </summary>
    [EnumMember(Value = @"update")]
    Update = 1,
}