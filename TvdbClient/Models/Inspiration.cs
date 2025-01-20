namespace Tvdb.Models;

/// <summary>
/// Movie inspiration record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Inspiration : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public string Type { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("type_name")]
    public string Type_name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("url")]
    public string Url { get; set; }
}