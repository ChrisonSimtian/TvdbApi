namespace Tvdb.Models;

/// <summary>
/// base award nominee record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AwardNomineeBaseRecord : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("character")]
    public Character Character { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("details")]
    public string Details { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("episode")]
    public EpisodeBaseRecord Episode { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("isWinner")]
    public bool? IsWinner { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("movie")]
    public MovieBaseRecord Movie { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("series")]
    public SeriesBaseRecord Series { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("year")]
    public string Year { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("category")]
    public string Category { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }
}