using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// extended list record
/// </summary>
public partial class ListExtendedRecord : ListBaseRecord
{
    [System.Text.Json.Serialization.JsonPropertyName("entities")]
    public System.Collections.Generic.ICollection<Entity> Entities { get; set; }
}