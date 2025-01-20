namespace Tvdb.Models;

/// <summary>
/// Movie inspiration type record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class InspirationType : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("description")]
    public string Description { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("reference_name")]
    public string Reference_name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("url")]
    public string Url { get; set; }
}