namespace Tvdb.Models;

/// <summary>
/// studio record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class StudioBaseRecord : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("parentStudio")]
    public int? ParentStudio { get; set; }
}