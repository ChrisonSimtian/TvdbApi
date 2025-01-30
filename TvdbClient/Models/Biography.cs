namespace Tvdb.Models;

/// <summary>
/// biography record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class Biography : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("biography")]
    public string Biography1 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("language")]
    public string Language { get; set; }
}