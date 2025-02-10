using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// Entity Type record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public class EntityType : AbstractBaseRecord
{

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("hasSpecials")]
    public bool? HasSpecials { get; set; }
}