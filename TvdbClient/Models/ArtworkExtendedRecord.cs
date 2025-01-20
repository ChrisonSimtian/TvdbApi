namespace Tvdb.Models;

/// <summary>
/// extended artwork record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ArtworkExtendedRecord : ArtworkBaseRecord
{
    [System.Text.Json.Serialization.JsonPropertyName("episodeId")]
    public int? EpisodeId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("movieId")]
    public int? MovieId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("networkId")]
    public int? NetworkId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("peopleId")]
    public int? PeopleId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("seasonId")]
    public int? SeasonId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("seriesId")]
    public int? SeriesId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("seriesPeopleId")]
    public int? SeriesPeopleId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public ArtworkStatus Status { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("tagOptions")]
    public System.Collections.Generic.ICollection<TagOption> TagOptions { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("thumbnailHeight")]
    public long? ThumbnailHeight { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("thumbnailWidth")]
    public long? ThumbnailWidth { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
    public long? UpdatedAt { get; set; }
}