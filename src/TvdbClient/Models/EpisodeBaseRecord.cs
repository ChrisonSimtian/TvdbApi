using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// base episode record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public class EpisodeBaseRecord : AbstractBaseRecord
{
    /// <summary>
    /// TVDB Episode Id
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// Absolute number of the episode
    /// </summary>
    [JsonPropertyName("absoluteNumber")]
    public int? AbsoluteNumber { get; set; }

    /// <summary>
    /// Aired Date
    /// </summary>
    [JsonConverter(typeof(Converters.DateTimeConverter))]
    [JsonPropertyName("aired")]
    public DateTime? Aired { get; set; }

    /// <summary>
    /// Used for Specials to indicate which season they belong to
    /// </summary>
    /// <remarks>Before which Season does this Episode air?</remarks>
    [JsonPropertyName("airsAfterSeason")]
    public int? AirsAfterSeason { get; set; }

    /// <summary>
    /// Used for Specials to indicate which Episode they belong to
    /// </summary>
    /// <remarks>Before which Episode does this Episode air?</remarks>
    [JsonPropertyName("airsBeforeEpisode")]
    public int? AirsBeforeEpisode { get; set; }

    /// <summary>
    /// Used for Specials to indicate which season they belong to
    /// </summary>
    /// <remarks>After which Season does this Episode air?</remarks>
    [JsonPropertyName("airsBeforeSeason")]
    public int? AirsBeforeSeason { get; set; }

    /// <summary>
    /// season, midseason, or series
    /// </summary>
    [JsonPropertyName("finaleType")]
    public string FinaleType { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; }

    [JsonPropertyName("imageType")]
    public int? ImageType { get; set; }

    /// <summary>
    /// Is this a movie?
    /// </summary>
    [JsonPropertyName("isMovie")]
    public int? IsMovie { get; set; }

    /// <summary>
    /// Last Updated on TVDB
    /// </summary>
    [JsonConverter(typeof(Converters.DateTimeConverter))]
    [JsonPropertyName("lastUpdated")]
    public DateTime? LastUpdated { get; set; }

    /// <summary>
    /// Linked Movie
    /// </summary>
    [JsonPropertyName("linkedMovie")]
    public int? LinkedMovie { get; set; }

    /// <summary>
    /// Episode Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Episode Name Translations
    /// </summary>
    [JsonPropertyName("nameTranslations")]
    public ICollection<string> NameTranslations { get; set; }

    /// <summary>
    /// Episode Number
    /// </summary>
    [JsonPropertyName("number")]
    public int Number { get; set; }

    /// <summary>
    /// Overview
    /// </summary>
    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    /// <summary>
    /// Overview Translations
    /// </summary>
    [JsonPropertyName("overviewTranslations")]
    public ICollection<string> OverviewTranslations { get; set; }

    /// <summary>
    /// How many minutes does this episode run?
    /// </summary>
    [JsonPropertyName("runtime")]
    public int? Runtime { get; set; }

    /// <summary>
    /// Season Number
    /// </summary>
    [JsonPropertyName("seasonNumber")]
    public int SeasonNumber { get; set; }

    /// <summary>
    /// Seasons
    /// </summary>
    [JsonPropertyName("seasons")]
    public ICollection<SeasonBaseRecord> Seasons { get; set; }

    /// <summary>
    /// TVDB Series Id
    /// </summary>
    [JsonPropertyName("seriesId")]
    public long? SeriesId { get; set; }

    /// <summary>
    /// Season Name
    /// </summary>
    [JsonPropertyName("seasonName")]
    public string SeasonName { get; set; }

    /// <summary>
    /// Year the Episode was published
    /// </summary>
    [JsonPropertyName("year")]
    public string Year { get; set; }
}