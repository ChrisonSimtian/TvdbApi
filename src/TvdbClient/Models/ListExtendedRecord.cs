using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// extended list record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ListExtendedRecord : ListBaseRecord
{
    [JsonPropertyName("entities")]
    public ICollection<Entity> Entities { get; set; }
}