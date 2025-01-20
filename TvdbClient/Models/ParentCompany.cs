namespace Tvdb.Models;

/// <summary>
/// A parent company record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ParentCompany : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public int? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("relation")]
    public CompanyRelationShip Relation { get; set; }
}