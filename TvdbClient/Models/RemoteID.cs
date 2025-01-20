namespace Tvdb.Models;

/// <summary>
/// remote id record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class RemoteID : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public string Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public long? Type { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("sourceName")]
    public string SourceName { get; set; }
}