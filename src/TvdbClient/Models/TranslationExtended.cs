namespace Tvdb.Models;

/// <summary>
/// translation extended record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class TranslationExtended : Translation
{

    [System.Text.Json.Serialization.JsonPropertyName("nameTranslations")]
    public System.Collections.Generic.ICollection<Translation> NameTranslations { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("overviewTranslations")]
    public System.Collections.Generic.ICollection<Translation> OverviewTranslations { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("alias")]
    public System.Collections.Generic.ICollection<string> Alias { get; set; }
}