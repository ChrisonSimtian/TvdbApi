namespace Tvdb.Models;

/// <summary>
/// release record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class Release : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("country")]
    public string Country { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("date")]
    public string Date { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("detail")]
    public string Detail { get; set; }
}