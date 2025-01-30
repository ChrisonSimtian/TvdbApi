using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// people type record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PeopleType : AbstractBaseRecord
{
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}