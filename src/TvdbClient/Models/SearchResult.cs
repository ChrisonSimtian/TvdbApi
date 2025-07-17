namespace Tvdb.Models;

/// <summary>
/// search result
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class SearchResult : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("aliases")]
    public System.Collections.Generic.ICollection<string> Aliases { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("companies")]
    public System.Collections.Generic.ICollection<string> Companies { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("companyType")]
    public string CompanyType { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("country")]
    public string Country { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("director")]
    public string Director { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("first_air_time")]
    public string First_air_time { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("genres")]
    public System.Collections.Generic.ICollection<string> Genres { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public string Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("image_url")]
    public string Image_url { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("is_official")]
    public bool? Is_official { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name_translated")]
    public string Name_translated { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("network")]
    public string Network { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("objectID")]
    public string ObjectID { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("officialList")]
    public string OfficialList { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("overview")]
    public string Overview { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("overviews")]
    public TranslationSimple Overviews { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("overview_translated")]
    public System.Collections.Generic.ICollection<string> Overview_translated { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("poster")]
    public string Poster { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("posters")]
    public System.Collections.Generic.ICollection<string> Posters { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("primary_language")]
    public string Primary_language { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("remote_ids")]
    public System.Collections.Generic.ICollection<RemoteID> Remote_ids { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public string Status { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("slug")]
    public string Slug { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("studios")]
    public System.Collections.Generic.ICollection<string> Studios { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("title")]
    public string Title { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("translations")]
    public TranslationSimple Translations { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("translationsWithLang")]
    public System.Collections.Generic.ICollection<string> TranslationsWithLang { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("tvdb_id")]
    public string Tvdb_id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public string Type { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("year")]
    public string Year { get; set; }
}