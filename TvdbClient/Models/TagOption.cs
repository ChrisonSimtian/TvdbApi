namespace Tvdb.Models;

/// <summary>
/// tag option record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class TagOption : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("helpText")]
    public string HelpText { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("tag")]
    public long? Tag { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("tagName")]
    public string TagName { get; set; }
}