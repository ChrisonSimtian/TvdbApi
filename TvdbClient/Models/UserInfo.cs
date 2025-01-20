namespace Tvdb.Models;

/// <summary>
/// User info record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class UserInfo : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public int? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("language")]
    public string Language { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public string Type { get; set; }
}