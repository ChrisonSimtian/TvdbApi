namespace Tvdb.Models;

/// <summary>
/// a entity with selected tag option
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class TagOptionEntity : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("tagName")]
    public string TagName { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("tagId")]
    public int? TagId { get; set; }
}