namespace Tvdb.Models;

/// <summary>
/// base list record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ListBaseRecord : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("aliases")]
    public System.Collections.Generic.ICollection<Alias> Aliases { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("image")]
    public string Image { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("imageIsFallback")]
    public bool? ImageIsFallback { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("isOfficial")]
    public bool? IsOfficial { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("nameTranslations")]
    public System.Collections.Generic.ICollection<string> NameTranslations { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("overview")]
    public string Overview { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("overviewTranslations")]
    public System.Collections.Generic.ICollection<string> OverviewTranslations { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("remoteIds")]
    public System.Collections.Generic.ICollection<RemoteID> RemoteIds { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("tags")]
    public System.Collections.Generic.ICollection<TagOption> Tags { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("score")]
    public int? Score { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("url")]
    public string Url { get; set; }
}