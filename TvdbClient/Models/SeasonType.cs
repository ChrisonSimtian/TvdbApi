namespace Tvdb.Models;

/// <summary>
/// season type record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class SeasonType : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("alternateName")]
    public string AlternateName { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public string Type { get; set; }
}