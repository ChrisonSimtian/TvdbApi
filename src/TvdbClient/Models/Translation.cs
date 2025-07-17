namespace Tvdb.Models;

/// <summary>
/// translation record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class Translation : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("aliases")]
    public System.Collections.Generic.ICollection<string> Aliases { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("isAlias")]
    public bool? IsAlias { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("isPrimary")]
    public bool? IsPrimary { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("language")]
    public string Language { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("overview")]
    public string Overview { get; set; }

    /// <summary>
    /// Only populated for movie translations.  We disallow taglines without a title.
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("tagline")]
    public string Tagline { get; set; }
}