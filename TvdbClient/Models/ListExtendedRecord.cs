using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// extended list record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ListExtendedRecord : ListBaseRecord
{
    [JsonPropertyName("entities")]
    public ICollection<Entity> Entities { get; set; }
}