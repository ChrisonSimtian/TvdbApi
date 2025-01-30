using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// artwork status record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public class ArtworkStatus : AbstractBaseRecord
{

    [JsonPropertyName("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}