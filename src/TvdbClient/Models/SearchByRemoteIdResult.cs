namespace Tvdb.Models;

/// <summary>
/// search by remote reuslt is a base record for a movie, series, people, season or company search result
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class SearchByRemoteIdResult : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("series")]
    public SeriesBaseRecord Series { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("people")]
    public PeopleBaseRecord People { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("movie")]
    public MovieBaseRecord Movie { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("episode")]
    public EpisodeBaseRecord Episode { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("company")]
    public Company Company { get; set; }
}