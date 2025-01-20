using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// country record
/// </summary>
public class Country : AbstractBaseRecord
{

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("shortCode")]
    public string ShortCode { get; set; }
}