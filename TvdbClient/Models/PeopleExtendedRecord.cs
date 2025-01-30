using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// extended people record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PeopleExtendedRecord : PeopleBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("aliases")]
    public System.Collections.Generic.ICollection<Alias> Aliases { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("awards")]
    public System.Collections.Generic.ICollection<AwardBaseRecord> Awards { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("biographies")]
    public System.Collections.Generic.ICollection<Biography> Biographies { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("birth")]
    public string Birth { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("birthPlace")]
    public string BirthPlace { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("characters")]
    public System.Collections.Generic.ICollection<Character> Characters { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("death")]
    public string Death { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("gender")]
    public int? Gender { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("image")]
    public string Image { get; set; }

    [JsonConverter(typeof(Converters.DateTimeConverter))]

    [System.Text.Json.Serialization.JsonPropertyName("lastUpdated")]
    public DateTime? LastUpdated { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("nameTranslations")]
    public System.Collections.Generic.ICollection<string> NameTranslations { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("overviewTranslations")]
    public System.Collections.Generic.ICollection<string> OverviewTranslations { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("races")]
    public System.Collections.Generic.ICollection<Race> Races { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("remoteIds")]
    public System.Collections.Generic.ICollection<RemoteID> RemoteIds { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("score")]
    public long? Score { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("slug")]
    public string Slug { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("tagOptions")]
    public System.Collections.Generic.ICollection<TagOption> TagOptions { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("translations")]
    public TranslationExtended Translations { get; set; }
}