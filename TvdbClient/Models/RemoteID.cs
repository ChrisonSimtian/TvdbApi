namespace Tvdb.Models;

/// <summary>
/// remote id record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class RemoteID : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public string Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public long? Type { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("sourceName")]
    public string SourceName { get; set; }
}