namespace Tvdb.Models;

/// <summary>
/// character record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Character : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("aliases")]
    public System.Collections.Generic.ICollection<Alias> Aliases { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("episode")]
    public RecordInfo Episode { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("episodeId")]
    public int? EpisodeId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("image")]
    public string Image { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("isFeatured")]
    public bool? IsFeatured { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("movieId")]
    public int? MovieId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("movie")]
    public RecordInfo Movie { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("nameTranslations")]
    public System.Collections.Generic.ICollection<string> NameTranslations { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("overviewTranslations")]
    public System.Collections.Generic.ICollection<string> OverviewTranslations { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("peopleId")]
    public int? PeopleId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("personImgURL")]
    public string PersonImgURL { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("peopleType")]
    public string PeopleType { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("seriesId")]
    public int? SeriesId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("series")]
    public RecordInfo Series { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("sort")]
    public long? Sort { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("tagOptions")]
    public System.Collections.Generic.ICollection<TagOption> TagOptions { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public long? Type { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("url")]
    public string Url { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("personName")]
    public string PersonName { get; set; }
}