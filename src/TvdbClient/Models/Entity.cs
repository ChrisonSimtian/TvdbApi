using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// Entity record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public class Entity : AbstractBaseRecord
{

    [JsonPropertyName("movieId")]
    public int? MovieId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("order")]
    public long? Order { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("seriesId")]
    public int? SeriesId { get; set; }
}