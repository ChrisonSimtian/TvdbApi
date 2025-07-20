namespace Tvdb.Models;

/// <summary>
/// language record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class Language : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public string Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("nativeName")]
    public string NativeName { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("shortCode")]
    public string ShortCode { get; set; }
}