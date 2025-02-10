namespace Tvdb.Models;

/// <summary>
/// source type record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class SourceType : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("postfix")]
    public string Postfix { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("prefix")]
    public string Prefix { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("slug")]
    public string Slug { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("sort")]
    public long? Sort { get; set; }
}