namespace Tvdb.Models;

/// <summary>
/// base record info
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class RecordInfo : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("image")]
    public string Image { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("year")]
    public string Year { get; set; }
}