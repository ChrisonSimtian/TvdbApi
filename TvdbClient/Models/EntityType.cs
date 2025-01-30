using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// Entity Type record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EntityType : AbstractBaseRecord
{

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("hasSpecials")]
    public bool? HasSpecials { get; set; }
}