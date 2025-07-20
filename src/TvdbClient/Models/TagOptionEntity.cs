namespace Tvdb.Models;

/// <summary>
/// a entity with selected tag option
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class TagOptionEntity : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("tagName")]
    public string TagName { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("tagId")]
    public int? TagId { get; set; }
}